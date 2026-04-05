# Dockerfile

# Use Python 3.9 as the base image
FROM python:3.9

# Set the working directory in the container
WORKDIR /app

# Install system dependencies for Unity automation
RUN apt-get update && \
    apt-get install -y \
    wget \
    unzip \
    libgtk-3-0 \
    libglu1-mesa

# Copy automation scripts
COPY ./scripts /app/scripts

# Install Python dependencies if needed
COPY requirements.txt ./
RUN pip install --no-cache-dir -r requirements.txt

# Command to run your automation scripts
CMD ["python", "./scripts/automation_script.py"]