<img src="assets/logo_rocket.png" align="right" width="128" height="128" />

> This is the master (release) branch, see [`devel`](https://github.com/steviegt6/holocure-launcher/tree/devel) for development versions.

# HoloCure.Launcher ![License](https://img.shields.io/github/license/steviegt6/holocure-launcher?style=flat-square) ![Release](https://img.shields.io/github/v/release/steviegt6/holocure-launcher?style=flat-square) ![Language](https://img.shields.io/badge/language-c%23-green?style=flat-square)

> An open-source launcher HoloCure!

**HoloCure.Launcher** is a feature-rich, free (as in both "freedom" and "free beer"), and open-source launcher for HoloCure, aiming to make your experience even better than before.

## Goals/Planned Features

* [ ] Full feature parity with the proprietary launcher:
  * [x] launcher auto-updating;
  * [ ] game auto-updating.
* [ ] Easy, accessible API for registering multiple *games* under the launcher:
  * [ ] unified system that takes a collection of `IGame` objects which describe how UI should be rendered and how profile management and game launching should be done.
* [ ] Mod-centric features:
  * [ ] profile management, allowing people to configure a save directory as well as manage what patches should be applied to the game;
  * [ ] an eventual custom build of HoloCure that is downloaded separately, instead of applied as patches (will be a separate `IGame` object).
