# TriviaGameAPI

For apply migrations to specified database that no exists you need follow this steps: 
1. To use specified DB go to TriviaGameAPI.DAL->ContextFactories->TriviaGameDBFactory and change connection string for your DB 
2. Select TriviaGameAPI.DAL as "Startup Project"
3. Open Package Manager, select "Default project" as TriviaGameAPI.DAL and input Update-Database 
4. Return TriviaGameAPI as "Startup Project"

Test client have this working things:
- Connect
- Join to room
- Leave from room
- Send message (hardcode message with sender ConnectionId and sent date)

Other GUI items not working (at the moment)

