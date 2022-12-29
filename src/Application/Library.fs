namespace Application

open System
open SleepingBearSystems.CraftingTools.Domain

type State = {
    Games: Map<Guid, Game>
}
with static member Initial = { Games = Map.empty }
