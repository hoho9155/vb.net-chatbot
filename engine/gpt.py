from llama_index import GPTVectorStoreIndex, SimpleDirectoryReader, GPTListIndex, readers, LLMPredictor, PromptHelper, ServiceContext, StorageContext, load_index_from_storage
from langchain import OpenAI
import gradio as gr
import sys
import os
from IPython.display import Markdown, display


def construct_index(directory_path):
    # set maximum input size
    max_input_size = 4096
    # set number of output tokens
    num_outputs = 2000
    # set chunk size limit
    chunk_size_limit = 600

    # define prompt helper
    prompt_helper = PromptHelper(max_input_size, num_outputs, chunk_overlap_ratio=0.1, chunk_size_limit=chunk_size_limit)

    # define LLM
    llm_predictor = LLMPredictor(llm=OpenAI(temperature=0.5, model_name="chatgpt-35-turbo", max_tokens=num_outputs))

    documents = SimpleDirectoryReader(directory_path).load_data()

    service_context = ServiceContext.from_defaults(llm_predictor=llm_predictor, prompt_helper=prompt_helper)
    index = GPTVectorStoreIndex.from_documents(documents, service_context=service_context)

    index.storage_context.persist('storage')

    return index

def ask_ai():
    try:
        storage_context = StorageContext.from_defaults(persist_dir="storage")
        index = load_index_from_storage(storage_context)
        query_engine = index.as_query_engine()

        while True:
            query = input("What do you want to ask?")
            response = query_engine.query(query)
            """display(Markdown(f"Response: {response.response}"))"""
            print(response.response)
    except Exception as e: 
        print(f"An error occurred: {e}")

os.environ["OPENAI_API_KEY"] = "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"
index = construct_index('./')
ask_ai()



