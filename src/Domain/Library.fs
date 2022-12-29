namespace SleepingBearSystems.CraftingTools.Domain

open System

type GameId = GameId of Guid

type GameName = GameName of string

type Game = { Id: GameId; Name: GameName }

type ProfessionId = ProfessionId of Guid

type ProfessionName = ProfessionName of string

type RecipeId = RecipeId of Guid

type Profession =
    { Id: ProfessionId
      Name: ProfessionName
      GameId: GameId }

type ItemId = ItemId of Guid

type ItemName = ItemName of string

type Item =
    { Id: ItemId
      Name: ItemName
      GameId: GameId }

type Inventory =
    { GameId: GameId
      Slots: Map<Guid, int> }

type RecipeName = RecipeName of string

type Recipe = {
    Id: RecipeId
    Name: RecipeName
    ProfessionId: ProfessionId
    Inputs: Map<ItemId, int>
    Outputs: Map<ItemId, int>
}
