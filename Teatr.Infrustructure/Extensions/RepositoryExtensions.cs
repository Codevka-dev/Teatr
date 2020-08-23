using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teatr.Core.Domain;
using Teatr.Core.Repositories;

namespace Teatr.Infrastructure.Extensions
{
    public static class RepositoryExtensions
    {
        public static async Task<Drama> GetOrFailAsync(this IDramaRepository dramaRepository, Guid id)
        {
            var drama = await dramaRepository.GetAsync(id);

            if (drama == null)
            {
                throw new Exception($"Drama name : {id} not exists");
            }

            return drama;
        }

        public static async Task<Act> GetOrFailAsync(this IActRepository actRepository, Guid id)
        {
            var act = await actRepository.GetAsync(id);

            if (act == null)
            {
                throw new Exception($"Act name : {id} not exists");
            }

            return act;
        }

        public static async Task<Scene> GetOrFailAsync(this ISceneRepository sceneRepository, Guid id)
        {
            var scene = await sceneRepository.GetAsync(id);

            if (scene == null)
            {
                throw new Exception($"Scene name : {id} not exists");
            }

            return scene;
        }

        public static async Task<Character> GetOrFailAsync(this ICharacterRepository characterRepository, Guid id)
        {
            var character = await characterRepository.GetAsync(id);

            if (character == null)
            {
                throw new Exception($"Character name : {id} not exists");
            }

            return character;
        }

        public static async Task<Sentence> GetOrFailAsync(this ISentenceRepository sentenceRepository, Guid id)
        {
            var sentence = await sentenceRepository.GetAsync(id);

            if (sentence == null)
            {
                throw new Exception($"Sentence name : {id} not exists");
            }

            return sentence;
        }
    }
}
