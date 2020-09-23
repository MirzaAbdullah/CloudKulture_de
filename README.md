# CloudKulture_de
Backend C# Api Demo

1. Create a public Git repository at a provider of your choosing (Github, GitLab, Bitbucket, etc) and send the URL to jobs@cloudkultur.de
2. Create a new project in C# (ASP .NET Core) or Go.
3. Comit your state into your Git repository, add the TAG „3_NewApi“
4. Create a new REST service under the route /helloapi/fibonacci
5. This service shall be invoked via HTTP GET and accept a parameter N (integer, >0)
6. For every integer delivered as parameter, the API calculates the respective Fibonacci number.
7. As result, the API delivers N as well as the calculated Fibonacci number. The response format can be XML or JSON format.
8. Comit your state into your Git repository, add the TAG „8_Fibonacci“
9. If N >= 12, the calculated value shall not correspond to the Fibonacci sequence, but always deliver 100.
10. Comit your state into your Git repository, add the TAG „9_PlanningPoker“
11. Create an HTTP client request using a tool of your choosing (Fiddler, Postman, CURL, etc), save the complete HTTP request and
the respective response in a text file.
12. Comit your state into your Git repository, add the TAG „12_HttpClient“
