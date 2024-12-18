<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Employee Approval - Setup Guide</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            line-height: 1.6;
            margin: 0;
            padding: 0 20px;
            background-color: #f9f9f9;
            color: #333;
        }
        h1, h2 {
            color: #444;
        }
        h1 {
            border-bottom: 2px solid #007bff;
            padding-bottom: 10px;
        }
        pre {
            background-color: #f4f4f4;
            border: 1px solid #ddd;
            padding: 10px;
            overflow-x: auto;
            border-radius: 5px;
        }
        code {
            font-family: Consolas, monospace;
            font-size: 1em;
        }
        .steps {
            margin: 20px 0;
        }
        ul {
            padding-left: 20px;
        }
        .highlight {
            color: #007bff;
            font-weight: bold;
        }
        .troubleshoot {
            background-color: #fffae6;
            border-left: 4px solid #ffcc00;
            padding: 10px;
            margin: 20px 0;
        }
    </style>
</head>
<body>
    <h1>Employee Approval with ASP.NET Core MVC</h1>
    <h2>Setup and Run ASP.NET Core MVC Project</h2>
    <p>Follow these steps to set up and run a <span class="highlight">.NET 7</span> project after cloning it:</p>
    
    <h2>Prerequisites</h2>
    <ul>
        <li>.NET 7 SDK (<a href="https://dotnet.microsoft.com/download/dotnet/7.0" target="_blank">Install from dotnet.microsoft.com</a>)</li>
        <li>MSSQL Server (Install locally or use a remote instance)</li>
        <li>Code Editor: Visual Studio 2022 (or Visual Studio Code)</li>
    </ul>

    <div class="steps">
        <h2>Steps</h2>
        
        <h3>1. Clone the Repository</h3>
        <pre><code>git clone &lt;repository-url&gt;
cd &lt;project-folder&gt;</code></pre>

        <h3>2. Restore Dependencies</h3>
        <pre><code>dotnet restore</code></pre>

        <h3>3. Configure the Database</h3>
        <p>Update the <code>appsettings.json</code> file with your MSSQL Server connection string:</p>
        <pre><code>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=USER;Password=PASSWORD;"
  }
}</code></pre>

        <h3>4. Apply Database Migrations</h3>
        <pre><code>dotnet ef database update</code></pre>

        <h3>5. Build and Run the Project</h3>
        <pre><code>dotnet clean
dotnet build
dotnet run</code></pre>

        <h3>6. Access the Application</h3>
        <p>Open the browser and navigate to the provided URL, e.g., <code>http://localhost:5000</code>.</p>

        <h3>Common Commands</h3>
        <table border="1" cellspacing="0" cellpadding="5">
            <tr>
                <th>Command</th>
                <th>Purpose</th>
            </tr>
            <tr>
                <td><code>dotnet restore</code></td>
                <td>Restore project dependencies</td>
            </tr>
            <tr>
                <td><code>dotnet ef database update</code></td>
                <td>Apply EF Core migrations</td>
            </tr>
            <tr>
                <td><code>dotnet build</code></td>
                <td>Build the project</td>
            </tr>
            <tr>
                <td><code>dotnet run</code></td>
                <td>Run the application</td>
            </tr>
        </table>
    </div>

    <div class="troubleshoot">
        <h2>Troubleshooting</h2>
        <ul>
            <li>Ensure MSSQL Server is running.</li>
            <li>Install EF CLI tools:</li>
            <pre><code>dotnet tool install --global dotnet-ef</code></pre>
            <li>Verify the .NET version:</li>
            <pre><code>dotnet --version</code></pre>
        </ul>
    </div>

    <p><strong>Done!</strong> Your project is now running locally 🚀.</p>
</body>
</html>
