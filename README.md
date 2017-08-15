
[![Build status](https://ci.appveyor.com/api/projects/status/t4cs6sx7hbsh89kw?svg=true)](https://ci.appveyor.com/project/bmatthewshea/actgen2)

ActGen - Random Code Generator 
==================

  - [Installation](#installation)
  - [Features](#features)
  - [TO DO](#to-do)
  - [License](#license)


## Installation

- The EXE can be placed anywhere. Optionally, you can place it with the exe.config and your custom settings.
- %appdata%\ActGen\user.config is only created if you "save settings on exit".

	Website/Contact: http://www.holylinux.net/code/actgen/

## Features

- Generate optionally with upper/lower letters, numbers, and symbols (Use "Include additional characters..").
- Use for passwords, activation and serial code lists.
- Can place dashes in generated code(s).
- Can save settings for quicker use later.

## TO-DO

- Fix the background worker problem / RNGCryptoServiceProvider - this should speed up generation.
- Fix major slowdown around 10k+ codes. 10000 codes = ~ 1 second. 20000 codes = ~ 4 seconds. 100k limit = minutes
- Once background workers fixed, start testing speed/randomness/repeats/etc.
- Create a new installer for the exectuable to create/cleanup %appdata%/ActGen, etc.
- basic code clean up - currently a mess -> you were warned.

## License

ActGen is released under the [GNU GPLv3](https://opensource.org/licenses/GPL-3.0).

<p><img src="http://i.imgur.com/u1G0wvD.png" width="475"></p>

<p><img src="https://assets-cdn.github.com/images/modules/logos_page/Octocat.png" width="175"></p>
