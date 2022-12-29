namespace SleepingBearSystems.CraftingTools.Domain

open System

module Game =
    let create (id: Guid) (name: string) : Result<Game, string> =
        let idResult = if id = Guid.Empty then Error "Invalid game ID." else Ok id

        let nameResult =
            if String.IsNullOrWhiteSpace name then
                Error "Invalid game name."
            else
                Ok name

        match idResult, nameResult with
        | Ok validId, Ok validName ->
            Ok
                { Id = GameId validId
                  Name = GameName validName }
        | _, _ -> Error "Unable to create game."

module Inventory =
    let create (game: Game) : Inventory = { GameId = game.Id; Slots = [] }

    let add (item: Item) (quantity: int) (inventory: Inventory) =
        { inventory with
            Slots =
                [ { ItemId = item.Id
                    Quantity = quantity } ]
                |> List.append inventory.Slots }

module Item =
    let create (game: Game) (id: Guid) (name: string) : Item =
        { Id = ItemId id
          Name = ItemName name
          GameId = game.Id }
