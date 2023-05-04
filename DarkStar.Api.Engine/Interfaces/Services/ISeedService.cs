using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DarkStar.Api.Engine.Interfaces.Services.Base;
using DarkStar.Api.World.Types.GameObjects;
using DarkStar.Api.World.Types.Tiles;
using DarkStar.Database.Entities.Base;

namespace DarkStar.Api.Engine.Interfaces.Services;

public interface ISeedService : IDarkSunEngineService
{
    void AddRaceToSeed(string race, string description, short tileId, BaseStatEntity stat);
    void AddGameObjectToSeed(string name, string description, int tileType, GameObjectType gameObjectType);
    void AddGameObjectSeed(string name, string description, string tileNAme, string gameObjectName, object data);
    void AddTextContentSeed(string name, string content);
    void AttachTextContentToItem(string gameObjectName, string textContentName);
    void AddItemSeed(
        string name, string description, int weight, string tileName, string category, string type, short equipLocation,
        short itemRarity, string sellDice, string buyDice, string attackDice, string defenseDice, string speed
    );
}