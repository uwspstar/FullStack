# use static readonly instead of using const
```
public static class Constants
    {
        static void PlayConstants()
        {
            Console.WriteLine(EditorThemes.DARK);
        }
        // use static readonly instead of using const
        public static class EditorThemes
        {
            // public const int LIGHT = 0;
            // public const int DARK = 1;
            // public const int PLAID = 2;
            public static readonly int LIGHT = 0;
            public static readonly int DARK = 1;
            public static readonly int PLAID = 2;
        }
        public static class Fighters
        {
            // public const string DEFAULT_FIGHTERNAME = "X-Wing";
            public static readonly string DEFAULT_FIGHTERNAME = "X-Wing";
            public static readonly Guid DEFAULT_FIGHTER_ID = Guid.Empty; // static readonly values work, too
        }

    }
```
### Enums
### Partial Classes
- put global constants in a Constants.cs file in the root or a centralized location, but make it a partial class and put additional partial Constants classes in other folders in your project.
