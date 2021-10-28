# BlogGraphQL
This is a simple Xamarin project. You need to have either Rider or Visual Studio code to run this. Also, copy the json blob and create a file name db.json to run the json-graphql-server. If you do not have that package follow this instructions: https://blog.logrocket.com/mocking-graphql-api-server-using-json-graphql-server/

In order to run this project you need to download json-graphql-server and run the following command:

```json-graphql-server db.json --p 5000```
 
 Here is the db.json file content.
 
 ```javascript {
    "posts": [
      {
        "id": 1,
        "title": "Lorem Ipsum",
        "views": 254,
        "user_id": 123
      },
      {
        "id": 2,
        "title": "Sic Dolor amet",
        "views": 65,
        "user_id": 456
      }
    ],
    "users": [
      {
        "id": 123,
        "name": "Luke Skywalker"
      },
      {
        "id": 456,
        "name": "Jack Bauer"
      },
      {
        "id": 654,
        "name": "Indiana Jones"
      }
    ],
    "comments": [
      {
        "id": 987,
        "post_id": 1,
        "body": "Consectetur adipiscing elit",
        "user_id": 123
      },
      {
        "id": 995,
        "post_id": 2,
        "body": "Nam molestie pellentesque dui",
        "user_id": 456
      },
      {
        "id": 999,
        "post_id": 1,
        "body": "quid agis",
        "user_id": 456
      }
    ]
  }
