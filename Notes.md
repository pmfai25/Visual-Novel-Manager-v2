These are just personal reminders for me to keep track of what I need to fix/add

- [ ] Dispose of views and viewmodels/free up memory
- [ ] Need to work on VnListViewModel for checking edge cases
- [ ] Set up virtualizing lists for large results
- [ ] Add "Update VN" to context menu
- [ ] Perhaps drop the VnTags/Traits table and use the local copies instead?
- [ ] Move the gear for add/remove categories to below the games, and have it be a context menu. At the top, have a box for filtering by category


- $1: I don't know if you plan on supporting collection .exes, where it has 3 VNs tied to one .exe





## Entity Framework Notes
I need to install these 2 packages from the nuget package manager(console doesn't work for second one)
```
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Tools
```


### Suggestions from Google Docs
- [ ] Run in taskbar while game is running
- [ ] Automatic updater
- [ ] Vndb Website within program
- [ ] Visual novel scanner to search for visual novels
- [ ] Userlist items with advanced sorting
- [ ] Section tags off by All/Content/ Sexual Content/ Technical content
- [ ] Multiple user profiles?!(probably hard to implement)
- [ ] search for walkthrough/ savegames
- [ ] Password required to do activities(change NSFW settings, set votes/status/…, view any data,....)
- [ ] Add a producers section, like list all Vns from KEY, Nitro+,...
- [ ] Advanced Category filters(sort by relase date,...)
- [ ] Be able to sort visual novels, and name categories, also being able to create sub categories would be nice. Example: sort by translated, or untranslated. Then further sort by producer/genre

### Cleanup notes:
- VnMainMODEL has some possible null referenceexceptions
- unload other views?

