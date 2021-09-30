Create a simple REST application for serving a blog.
It uses .Net Core 5.0 and a Mongo database.

Currently the application has 2 endpoints:

1) Get all blog posts
2) Get blog post by id 
3) To add a blog post
4) To delete a blog post by id

Your task is to add a commenting feature.

You should add two new endpoints.

1) Post at /blog/post/{1}/comment - which should create a new comment for a post with passed {id}

2) Get at /blog/post/{1}/comment - which should return all comments for a post with passed {id}
Write acceptable test coverage for the the new endpoints.

Under the resources folder are example json files for both a Blog and a Comment.

Feel free to modify existing files or create new files. You may add new dependencies if you choose. Please follow the conventions in place throughout the project.

You should not spend more than 4 hours on this task.Create a simple REST application for serving a blog.
