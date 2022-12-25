# PASSGEN

a command line password generator

## installation guide
---
install the nuget package from <a href=""> here</a> 

__Note : dotnet 7 is required__

go to the installation location and run this command

```
dotnet tool install passgen --global --add-source .
```

## Usage example
---
run the command `passgen` and you will get a message like this

The Password 98itI$!5&FGFSwb has been copied to your clipboard

you can see the available options with `--help` argument 

```
PC  ~  passgen --help
PassGen 1.0.0
Copyright (C) 2022 PassGen

  -l, --length       (Default: 15) Set the length of the password

  -u, --uppercase    (Default: false) Remove uppercase from genreated password

  -c, --lowercase    (Default: false) Remove lowercase from genreated password

  -n, --number       (Default: false) Remove numbers from genreated password

  -s, --special      (Default: false) Remove specials from genreated password

  --help             Display this help screen.

  --version          Display version information.
```

this command will generate a password with 25 characters and without lowercase and special characters

```
passgen -l 25 -c -s
```
the result will be
```
The Password 4AQYJTWSKUFK3O4I94DAD0GLF has been copied to your clipboard
```