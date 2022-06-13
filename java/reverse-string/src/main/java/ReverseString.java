class ReverseString {

    String reverse(String inputString) {
        int lastIndex = inputString.length() - 1;
        String reversedString = new String();
        char[] characters = inputString.toCharArray();
        for (int i = 0; i < inputString.length(); i++) {
            reversedString += characters[lastIndex];
            lastIndex--;
        }

        return reversedString;
    }
  
}
