# NucAI Chat 
## Visit the live site here: https://nucaichat-service-531457900792.us-central1.run.app/

Welcome to NucAI Chat, a web-based chat application built with Blazor Server. This project demonstrates a real-time, streaming chat experience with a personality-driven AI, "Nuclear Pasta," a snarky but brilliant 17-year-old programmer.

The application showcases several modern web development techniques, including real-time UI updates, interaction with a large language model (LLM), and dynamic styling with C# and CSS.


*(Recommended: Take a screenshot of your application, upload it to a service like Imgur, and replace the URL above to give visitors a visual preview.)*

## Features

*   **Personality-Driven AI**: Chat with "Nuclear Pasta," an AI with a unique and opinionated persona.
*   **Real-Time Streaming**: AI responses are streamed in real-time, character-by-character, for a dynamic user experience.
*   **Configurable Creativity**: Users can adjust the AI's "level of insanity" (the temperature/creativity of its responses) using a stylish, interactive slider.
*   **Markdown Rendering**: Chat messages are rendered as Markdown, allowing for formatted text and code blocks.
*   **Custom Theming**: The UI features a custom background with semi-transparent elements for a modern look.
*   **External Linking**: The navigation menu includes links that correctly open in new browser tabs.

## Technologies Used

*   **Framework**: [Blazor Server](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
*   **Language**: C#
*   **Platform**: .NET 8
*   **Markdown Parsing**: [Markdig](https://github.com/xoofx/markdig)
*   **AI Integration**: `Microsoft.Extensions.AI`

## Getting Started

You can just visit the live application here: https://nucaichat-service-531457900792.us-central1.run.app/ or install it yourself! 
Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You will need to have the following software installed on your machine:

1.  **`.NET SDK`**: This project requires the .NET SDK to build and run. You can download it from the official .NET website:
    *   [Download .NET](https://dotnet.microsoft.com/download) (Please ensure you install the SDK, not just the runtime).
2.  **Code Editor/IDE**:
    *   [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community Edition is free)
    *   [Visual Studio Code](https://code.visualstudio.com/) with the C# Dev Kit extension.

### Installation

1.  **Clone the Repository**
    Open your terminal or command prompt and run the following command to clone the project to your local machine:
    ```sh
    git clone https://github.com/your-username/your-repository-name.git
    ```

2.  **Navigate to the Project Directory**
    Change into the newly created project directory:
    ```sh
    cd your-repository-name
    ```

3.  **Restore Dependencies**
    The .NET CLI needs to download the project's dependencies (like Markdig and the AI libraries) as defined in the project file.
    ```sh
    dotnet restore
    ```

4.  **Configure AI Service**
    This project uses `IChatClient` which needs to be configured in `Program.cs`. If you are using a service like OpenAI or Azure OpenAI, you will need to add your API key to the project.
    
    It is highly recommended to use the .NET Secret Manager for this:
    ```sh
    dotnet user-secrets init
    dotnet user-secrets set "YourProvider:ApiKey" "your_actual_api_key_here"
    ```
    Ensure your `Program.cs` is set up to read this configuration.

5.  **Run the Application**
    Once the dependencies are restored, you can run the application using the .NET CLI:
    ```sh
    dotnet run
    ```
    The terminal will show the local URL where the application is running, typically `https://localhost:7XXX` or `http://localhost:5XXX`. Open this URL in your web browser.

You should now see the NucAI Chat application running and be able to interact with it.
