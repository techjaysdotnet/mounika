# Sample api creation

Create a project with ASP.NET Core Web API template in visual studio app.

## about files
launchSettings.json in Properties folder having the running port and url details
each custom API can be added in Controllers folder.
Here, I have created SampleController.cs and ValuesController.cs with the custom data

## running the project
save the files then Debug the project by selecting  Debug -> Start without debugging.
`[HttpGet("{id}")]` method has been used here to get the data for particular id, `[HttpGet]` for getting all the details
Now we can launch the api  url in the browser. For Ex: [to get sample api](http://localhost:44339/api/sample/) and [to get values api] https://localhost:44339/api/values/
Here sample and values are nothing but your controller names













