lass Solution {
    public static String oddEven(String s) {
        // code here
        int x=0;
        int y=0;
        int sum=0;
       int [] arraycount=new int[26];
       for(int i=0;i<s.length();i++){
           arraycount[(s.charAt(i)-'a')]++;
       }
       for(int i=0;i<s.length();i++){
           int position=(s.charAt(i)-'a');
           if((position%2)==0 && (arraycount[(s.charAt(i)-'a')])%2==0){
               x++;
               
               }
                if((position%2)!=0 && (arraycount[(s.charAt(i)-'a')])%2!=0){
               y++;
               
               }
               
               
       }
       sum=x+y;
       if((sum&1)==0){
           return "EVEN" ;
       }
       return "ODD";
    }
}
