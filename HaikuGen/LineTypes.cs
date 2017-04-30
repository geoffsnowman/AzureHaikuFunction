using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    internal static class LineTypes
    {
        private static Random _rand = new Random();

        internal static List<Structure> Structures = new List<Structure>
        {
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.TransitiveVerb,
                Vocabulary.Animal,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.TransitiveVerb,
                Vocabulary.SizeAdjective + Vocabulary.AgeAdjective,
                Vocabulary.Animal,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.AgeAdjective,
                Vocabulary.Animal,
                Vocabulary.TransitiveVerb,
                Vocabulary.AgeAdjective,
                Vocabulary.Animal,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.Adverb,
                Vocabulary.TransitiveVerb,
                Vocabulary.Animal,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.ColorAdjective + Vocabulary.MoodAdjective,
                Vocabulary.Animal,
                Vocabulary.IntransitiveVerb
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.ColorAdjective + Vocabulary.MoodAdjective + Vocabulary.SizeAdjective,
                Vocabulary.Animal,
                Vocabulary.IntransitiveVerb,
                Vocabulary.Adverb,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.IntransitiveVerb,
                Vocabulary.Adverb,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.MoodAdjective + Vocabulary.ColorAdjective,
                Vocabulary.Animal,
                Vocabulary.At,
                Vocabulary.TimeOfDay
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.MoodAdjective,
                Vocabulary.ColorAdjective + Vocabulary.SeasonAdjective,
                Vocabulary.TimeOfDay,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.MoodAdjective,
                Vocabulary.SeasonAdjective,
                Vocabulary.Place,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.MoodAdjective + Vocabulary.ColorAdjective,
                Vocabulary.Animal,
                Vocabulary.In,
                Vocabulary.Place + Vocabulary.SeasonAdjective,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.In,
                Vocabulary.ColorAdjective + Vocabulary.MoodAdjective + Vocabulary.SizeAdjective,
                Vocabulary.Place
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.TimeOfDay + Vocabulary.SeasonAdjective,
                Vocabulary.Animal,
                Vocabulary.IntransitiveVerb
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.TimeOfDay + Vocabulary.SeasonAdjective,
                Vocabulary.Animal,
                Vocabulary.IntransitiveVerb,
                Vocabulary.Adverb,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.MoodAdjective + Vocabulary.ColorAdjective,
                Vocabulary.Animal,
                Vocabulary.MotionVerb,
                Vocabulary.To + Vocabulary.From,
                Vocabulary.Place
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.Animal,
                Vocabulary.MotionVerb,
                Vocabulary.From + Vocabulary.To,
                Vocabulary.ColorAdjective + Vocabulary.MoodAdjective + Vocabulary.SizeAdjective,
                Vocabulary.Place,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.ColorAdjective,
                Vocabulary.Animal,
            }),
            new Structure(new List<StructureItem>
            {
                Vocabulary.ColorAdjective,
                Vocabulary.Place,
            }),
        };

        internal static Structure GetStructure()
        {
            int r = _rand.Next(Structures.Count);
            return Structures[r];
        }
    }
}
