using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaikuGen
{
    internal static class Vocabulary
    {
        private static Random _rand = new Random();

        public static StructureItem Animal = new StructureItem(new List<Word>
        {
            new Word("bat", 1),
            new Word("bear", 1),
            new Word("bird", 1),
            new Word("boy", 1),
            new Word("bull", 1),
            new Word("cat", 1),
            new Word("cook", 1),
            new Word("cow", 1),
            new Word("crab", 1),
            new Word("dog", 1),
            new Word("fox", 1),
            new Word("frog", 1),
            new Word("girl", 1),
            new Word("hare", 1),
            new Word("horse", 1),
            new Word("knight", 1),
            new Word("owl", 1),
            new Word("man", 1),
            new Word("mole", 1),
            new Word("mouse", 1),
            new Word("pig", 1),
            new Word("priest", 1),
            new Word("rat", 1),
            new Word("sheep", 1),
            new Word("snake", 1),
            new Word("toad", 1),
            new Word("wolf", 1),
            new Word("baker", 2),
            new Word("butcher", 2),
            new Word("cobra", 2),
            new Word("donkey", 2),
            new Word("farmer", 2),
            new Word("hero", 2),
            new Word("kitten", 2),
            new Word("monkey", 2),
            new Word("orphan", 2),
            new Word("parson", 2),
            new Word("pigeon", 1),
            new Word("prankster", 2),
            new Word("rabbit", 2),
            new Word("sailor", 2),
            new Word("soldier", 2),
            new Word("tiger", 2),
            new Word("vulture", 2),
            new Word("woman", 2),
            new Word("boat captain", 3),
            new Word("charlatan", 3),
            new Word("fisherman", 3),
        });

        public static StructureItem Place = new StructureItem(new List<Word>
        {
            new Word("bay", 1),
            new Word("cave", 1),
            new Word("creek", 1),
            new Word("hut", 1),
            new Word("lake", 1),
            new Word("pit", 1),
            new Word("pond", 1),
            new Word("town", 1),
            new Word("trap", 1),
            new Word("woods", 1),
            new Word("cavern", 2),
            new Word("city", 2),
            new Word("dwelling", 2),
            new Word("forest", 2),
            new Word("hovel", 2),
            new Word("mansion", 2),
            new Word("meadow", 2),
            new Word("river", 2),
            new Word("village", 2),
            new Word("workshop", 2),

        });

        public static StructureItem TimeOfDay = new StructureItem(new List<Word>
        {
            new Word("dawn", 1),
            new Word("dusk", 1),
            new Word("lunch", 1),
            new Word("night", 1),
            new Word("noon", 1),
            new Word("daybreak", 2),
            new Word("mid day", 2),
            new Word("morning", 2),
            new Word("nightfall", 2),
            new Word("sunrise", 2),
            new Word("sunset", 2),
            new Word("afternoon", 3),
            new Word("evening", 3),

        });

        public static StructureItem IntransitiveVerb = new StructureItem(new List<Word>
        {
            new Word("climbs", 1),
            new Word("cries", 1),
            new Word("dies", 1),
            new Word("eats", 1),
            new Word("flees", 1),
            new Word("gripes", 1),
            new Word("runs", 1),
            new Word("screams", 1),
            new Word("talks", 1),
            new Word("writhes", 1),
            new Word("dances", 2),
            new Word("shivers", 2),
            new Word("trembles", 2),
            new Word("wails", 2),
            new Word("whispers", 2),

        });

        public static StructureItem TransitiveVerb = new StructureItem(new List<Word>
        {
            new Word("cheers", 1),
            new Word("dreads", 1),
            new Word("fears", 1),
            new Word("fights", 1),
            new Word("flees", 1),
            new Word("slays", 1),
            new Word("fights with", 2),
            new Word("kisses", 2),
            new Word("laughs at", 2),
            new Word("plays with", 2),
            new Word("smiles at", 2),
            new Word("sneers at", 2),
            new Word("embraces", 3),

        });

        public static StructureItem MotionVerb = new StructureItem(new List<Word>
        {
            new Word("crawls", 1),
            new Word("flies", 1),
            new Word("runs", 1),
            new Word("strides", 2),
            new Word("strolls", 1),
            new Word("trots", 1),
            new Word("walks", 1),
            new Word("gallops", 2),
            new Word("hurries", 2),
            new Word("marches", 2),
            new Word("parades", 2),
            new Word("rushes", 2),
            new Word("scuttles", 2),

        });

        public static StructureItem ColorAdjective = new StructureItem(new List<Word>
        {
            new Word("blue", 1),
            new Word("green", 1),
            new Word("mauve", 1),
            new Word("red", 1),
            new Word("amber", 2),
            new Word("ash grey", 2),
            new Word("blood red", 2),
            new Word("crimson", 2),
            new Word("cyan", 2),
            new Word("pumpkin", 2),
            new Word("purple", 2),
            new Word("ruby", 2),
            new Word("sky blue", 2),
            new Word("topaz", 2),
            new Word("wine red", 2),
            new Word("yellow", 2),
            new Word("apple green", 3),
            new Word("baby pink", 3),
            new Word("bright lilac", 3),
            new Word("burnt orange", 3),
            new Word("canary", 3),
            new Word("candy pink", 3),
            new Word("carmine pink", 3),
            new Word("cinnamon", 3),
            new Word("coral red", 3),
            new Word("emerald", 3),
            new Word("flamingo", 3),
            new Word("forest green", 3),
            new Word("goldenrod", 3),
            new Word("jungle green", 3),
            new Word("lavender", 3),
            new Word("magenta", 3),
            new Word("pale blue", 3),
            new Word("royal blue", 3),
            new Word("sapphire", 3),
            new Word("shadow black", 3),
            new Word("violet", 3),
            new Word("bitter lemon", 4),
            new Word("robin egg blue", 4),
            new Word("sunset orange", 4),
            new Word("ultramarine", 4),
            new Word("celestial blue", 5),
            new Word("electric crimson", 5),

        });

        public static StructureItem MoodAdjective = new StructureItem(new List<Word>
        {
            new Word("mad", 1),
            new Word("sad", 1),
            new Word("blissful", 2),
            new Word("angry", 2),
            new Word("cheerful", 2),
            new Word("crying", 2),
            new Word("funny", 2),
            new Word("happy", 2),
            new Word("laughing", 2),
            new Word("screaming", 2),
            new Word("tragic", 2),
            new Word("melancholy", 4),

        });

        public static StructureItem SeasonAdjective = new StructureItem(new List<Word>
        {
            new Word("Fall", 1),
            new Word("June", 1),
            new Word("May", 1),
            new Word("Spring", 1),
            new Word("April", 2),
            new Word("August", 2),
            new Word("Autumn", 2),
            new Word("July", 2),
            new Word("Summer", 2),
            new Word("Winter", 2),
            new Word("December", 3),
            new Word("November", 3),
            new Word("October", 3),
            new Word("September", 3),
            new Word("January", 4),
            new Word("February", 4),
            
        });

        public static StructureItem SizeAdjective = new StructureItem(new List<Word>
        {
            new Word("big", 1),
            new Word("fat", 1),
            new Word("huge", 1),
            new Word("small", 1),
            new Word("thin", 1),
            new Word("vast", 1),
            new Word("little", 2),
            new Word("tiny", 2),
            new Word("enormous", 3),
            new Word("tremendous", 3),

        });

        public static StructureItem AgeAdjective = new StructureItem(new List<Word>
        {
            new Word("old", 1),
            new Word("sick", 1),
            new Word("young", 1),
            new Word("aged", 2),
            new Word("ailing", 2),
            new Word("fledgling", 2),
            new Word("infant", 2),
            new Word("newborn", 2),
            new Word("older", 2),
            new Word("younger", 2),
            new Word("mature", 3),
            new Word("pubescent", 3),

        });

        public static StructureItem Adverb = new StructureItem(new List<Word>
        {
            new Word("bleakly", 2),
            new Word("blindly", 2),
            new Word("gladly", 2),
            new Word("lightly", 2),
            new Word("quickly", 2),
            new Word("sadly", 2),
            new Word("slowly", 2),
            new Word("smoothly", 2),
            new Word("strangely", 2),
            new Word("angrily", 3),
            new Word("boastfully", 3),
            new Word("carefully", 3),
            new Word("daintily", 3),
            new Word("gracefully", 3),
            new Word("happily", 3),
            new Word("joyfully", 3),
            new Word("knowingly", 3),
            new Word("lazily", 3),
            new Word("playfully", 3),
            new Word("quietly", 3),
            new Word("woefully", 3),
            new Word("defiantly", 4),
            new Word("ferociously", 4),
            new Word("furiously", 4),

        });

        public static StructureItem At = new StructureItem(new List<Word>
        {
            new Word("at", 1)
        });

        public static StructureItem In = new StructureItem(new List<Word>
        {
            new Word("in", 1)
        });

        public static StructureItem To = new StructureItem(new List<Word>
        {
            new Word("to", 1)
        });

        public static StructureItem From = new StructureItem(new List<Word>
        {
            new Word("from", 1)
        });
    }
}
