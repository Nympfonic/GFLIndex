<h1 align="center">
    <img src="header.png" />
</h1>

> Allows you to view data on all obtainable characters in Girls' Frontline (GFL).

This project consists of an ASP.NET Core Web API serving as the backend, with a ReactJS frontend which allows users to view data about GFL characters from, currently, a local SQL database. It also allows the user to add, update, and remove data in the database.

## Setup

### Windows

You will need [Git](https://git-scm.com) and [Node.js](https://nodejs.org/en/download/) installed on your computer.

1. In the command line:

    ```bash
    # Clone this repository
    $ git clone https://github.com/Nympfonic/GFLIndex.git

    # Go into the repository
    $ cd GFLIndex

    # Install dependencies
    $ npm install
    ```

2. Run the `PopulateDatabase.sql` script

3. Open the `GFLIndex.sln` project solution

4. Build and run the project

## Meta

Nympfonic – arys.steam@gmail.com

Distributed under the MIT license. See ``LICENSE`` for more information.

[https://github.com/Nympfonic](https://github.com/Nympfonic)

## Contributing

1. Fork it (<https://github.com/Nympfonic/GFLIndex/fork>)
2. Create your feature branch (`git checkout -b feature/fooBar`)
3. Commit your changes (`git commit -am 'Add some fooBar'`)
4. Push to the branch (`git push origin feature/fooBar`)
5. Create a new Pull Request
