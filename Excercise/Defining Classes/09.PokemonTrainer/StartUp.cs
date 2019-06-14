using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();
            trainers = GettAllTrainers(trainers);

            string command = Console.ReadLine();

            while (command!="End")
            {
                trainers.ForEach(x => x.Action(command));

                command = Console.ReadLine();
            }

            foreach (Trainer trainer in trainers.OrderByDescending(x=>x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static List<Trainer> GettAllTrainers(List<Trainer> trainers)
        {
            string[] input = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = int.Parse(input[3]);

                Pokemon currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                bool isExistTrainer = trainers.Any(x => x.Name == trainerName);

                if (isExistTrainer)
                {
                    int index = trainers.IndexOf(trainers.FirstOrDefault(x => x.Name == trainerName));
                    trainers[index].Pokemons.Add(currentPokemon);
                }
                else
                {

                    Trainer currentTrainer = new Trainer(trainerName);
                    currentTrainer.Pokemons.Add(currentPokemon);

                    trainers.Add(currentTrainer);
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            return trainers;
        }
    }
}
