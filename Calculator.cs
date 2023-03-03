class Calculator{

    // REF

    /*public static void Triplicar(ref int x){
        x*=3;
    }*/


    // OUT
    public static void Triplicar(int origin, out int result){
        result = origin * 3;
    }
}