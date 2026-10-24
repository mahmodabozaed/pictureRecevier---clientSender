📸 Picture Receiver
A high-performance C# Windows Forms application that operates as a dedicated TCP server for real-time image streaming and in-memory rendering.

📌 Project Overview
Picture Receiver is designed to accept incoming network socket connections, receive image payload streams over TCP, and dynamically render them directly in the application interface without writing files to disk. Built with performance and simplicity in mind, it provides a clean graphical interface to monitor active data feeds and view real-time image transmissions.

✨ Features
TCP Server Architecture: Handles incoming socket connections and data buffers efficiently.

In-Memory Image Rendering: Displays stream data directly to avoid unnecessary disk I/O.

Windows Forms GUI: Clear status logs and picture container layout.

Low Latency: Optimized for lightweight payload handling and live updates.

⚙️ Requirements & Prerequisites
[!IMPORTANT]
.NET Framework / .NET SDK Required

To build, run, or develop this project on your machine, you must download and install the .NET Runtime / .NET SDK (version 10.0 or the version targeted by your environment). Without .NET installed, the project cannot be compiled or executed.

How to Download .NET:
Go to the official Microsoft .NET Download Page.

Download the .NET SDK (if you plan to build or modify the code) or the .NET Desktop Runtime (if you only plan to run the pre-compiled executable).

Follow the installer instructions for your operating system.

Verify your installation by running the following command in your terminal or Command Prompt:

Bash
dotnet --version



🚀 Quick Start / How to Run
Clone the repository:

Bash
git clone https://github.com/your-username/picture-receiver.git
cd picture-receiver
Build and Run:

Bash
dotnet build
dotnet run

Short Repository Summary (For the top GitHub "About" box)
A C# Windows Forms TCP server application for real-time image streaming and rendering. Requires the .NET Runtime/SDK.
