# 🖼️ Picture Receiver (Server)

[![.NET 10.0](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-0078D6?style=flat-square&logo=windows)](https://www.microsoft.com/windows)

A desktop application built using **C#** and **Windows Forms** that functions as a TCP server to listen for incoming network connections and render received images in real time.

---

## 📌 Overview

The **Picture Receiver** creates a dedicated TCP listener on a designated network port. When a client application connects and transmits image byte data, the receiver intercepts the stream, dynamically renders the image inside a `PictureBox` control, and gracefully closes the connection.

```text
+-------------------+              TCP Connection               +-----------------------+
|                   |  ------------------------------------->   |                       |
|   TCP Client      |             Port: 5020                    |   Picture Receiver    |
| (Image Sender)    |                                           |       (Server)        |
|                   |  ==== Sends Raw Image Stream Data ====>   |                       |
+-------------------+                                           +-----------------------+
                                                                            |
                                                                            v
                                                                +-----------------------+
                                                                | Render to PictureBox  |
                                                                | (PictureBoxSizeMode)  |
                                                                +-----------------------+


## ✨ Features

* **TCP Listener Setup:** Listens on all available IP addresses (`IPAddress.Any`) on port **5020**.
* **Real-Time Image Rendering:** Converts incoming network streams directly into image objects using `Image.FromStream`.
* **Responsive Layout:** Displays images using `PictureBoxSizeMode.Zoom` to preserve aspect ratio within a 300 × 300 pixel area.
* **Interactive Feedback:** Provides dialog pop-ups alerting the user when waiting for a connection and confirming when an image is successfully rendered.

---

## ⚙️ Technical Specifications

| Parameter | Details |
| :--- | :--- |
| **Framework** | .NET 10.0 (Windows Forms) |
| **Language** | C# (Implicit Usings & Nullable Enabled) |
| **Listening Port** | `5020` |
| **IP Address** | `0.0.0.0` (`IPAddress.Any`) |
| **Target OS** | Windows |

---

## 📂 Project Structure

```text
pictureRecevier/
├── Form1.cs           # Main logic (TCP listener & socket handling)
├── Form1.Designer.cs  # UI layout (Button, Label, PictureBox initialization)
├── Program.cs         # Application entry point
└── pictureRecevier.csproj # Project configuration & .NET target framework
```

---

## 🛠️ How It Works

1. **Start Listening:** Clicking the **"Receive Image"** button triggers the `btnReceive_Click` event handler, invoking the `Image_Receiver()` method.
2. **Socket Connection:** A `TcpListener` binds to port `5020`, triggering a prompt that notifies the user the server is active.
3. **Data Transfer:** Once connected, the server reads raw binary image data directly using `NetworkStream`.
4. **Display & Cleanup:** The stream loads directly into `pictureBox1.Image` before closing the network stream, socket, and listener.

---

## 🚀 Getting Started

### Prerequisites

* [.NET 10.0 SDK](https://dotnet.microsoft.com/) installed on a Windows system.
* Visual Studio 2022 or VS Code with C# development workloads configured.

### Building & Running

1. **Clone or download** the repository to your local machine.
2. **Open a terminal** in the root project directory.
3. **Build the project:**
   ```bash
   dotnet build
   ```
4. **Run the application:**
   ```bash
   dotnet run
   ```

---

## 🌐 Network Requirements

> ⚠️ **Important Firewall Note:** Ensure your Windows Firewall permits incoming TCP traffic on **Port 5020**. The client application must transmit valid image bytes (e.g., JPEG, PNG) to the server's local IP address.