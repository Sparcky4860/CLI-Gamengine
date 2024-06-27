public class CLIRuntimevar
{
    public static double errors { get; set; } = 0;
     public static void rerror()
    {
        errors ++ ;
    }
}