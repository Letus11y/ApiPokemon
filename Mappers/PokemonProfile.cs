using System;
using PokeApi.Entities;
using PokeApi.Models;
using PokeApi.Extensions;
using Realms;

namespace PokeApi.Mappers
{
    public static class PokemonProfile
    {
        public static void ToEntity(this PokemonDetailModel obj, Realm realm)
        {
            var entity = new PokemonEntity
            {
                Id = MongoDB.Bson.ObjectId.GenerateNewId(),
                PokeId = obj.Id,
                Name = obj.Name,
                BaseExperience = obj.Base_Experience,
                Height = obj.Height,
                Sprites = obj.Sprites != null ? new PokemonSpriteEntity
                {
                    FrontDefault = obj.Sprites.FrontDefault,
                    BackDefault = obj.Sprites.BackDefault,
                    FrontShiny = obj.Sprites.FrontShiny,
                    BackShiny = obj.Sprites.BackShiny
                } : null
            };

            // // Iniciar una transacción de escritura
            // realm.Write(() =>
            // {
            //     // Agregar habilidades
            //     if (obj.Abilities != null)
            //     {
            //         foreach (var ability in obj.Abilities)
            //         {
            //             var abilityEntity = new PokemonAbilityEntity
            //             {
            //                 AbilityName = ability.Ability?.Name,
            //                 IsHidden = ability.IsHidden
            //             };
            //             entity.Abilities.Add(abilityEntity);
            //         }
            //     }

            //     // Agregar tipos
            //     if (obj.Types != null)
            //     {
            //         foreach (var type in obj.Types)
            //         {
            //             var typeEntity = new PokemonTypeEntity
            //             {
            //                 Slot = type.Slot,
            //                 TypeName = type.Type?.Name
            //             };
            //             entity.Types.Add(typeEntity);
            //         }
            //     }

            //     // Agregar el objeto entity al Realm
            //     realm.Add(entity);
            // });
        }
    }
}
