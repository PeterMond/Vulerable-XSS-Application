# Vulnerable XSS Application

## Purpose

This is an ASP.NET MVC application I made in order to learn more about XSS and how to prevent it. The application has pages that contain an example that is vulnerable to XSS and one that is fixed with encoding. There is also additional documentation on what is actually going on in each example to ensure that the fix is clear. 

## Running the Application

The application was developed using ASP.NET Core 3. If you choose to run it outside of Docker, then go to https://dotnet.microsoft.com and get the latest version of .NET Core for your platform. The application is cross platform so it will work on Windows, Linux, MAC OS X, and any other platform supported by Microsoft. The code builds successfully under both Visual Studio 2017 and 2019 and can be run both under IIS. When you run it using the key combination ctrl+F5, the application will open in your default browser.

## Payloads 

| Page/Context | Payload | Why it Works | Quick Fix |
|--------------|---------|--------------|-----------|
| XSS in basic HTML context| <script>alert(1)</script> | The data is reflected right back on the the page in an HTML context with being encoded | HTML encoding before the page is returned |
| XSS in JavaScript Context | "; alert(1); " | The data is directly put into a JavaScript variable. You can use the quotes and semicolon to end that command and execute your own arbitary JavaScript after that. | JavaScript string encode the data before it is placed into the DOM |
| XSS in HTML attribute context | " onmouseover="alert(1) | The data is put into a value parameter in an HTML tag without being encoded. adding a quote allows you to end the value attribute and add an even handler and run JavaScript | HTML encoding before the page is returned |