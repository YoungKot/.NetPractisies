1. How to run the code??
2. The project is not logically organized, difficult to read. Subfolders are advised
   1. Developer intention should be clearly seen from the code
3. Too many classes. 
    1. Some classes can be make public static as they have no data members. So less allocations will happen
    2. CSVReader and CSVWriter can be joined together. Otherwise CSVWriter doesn't seem to be useful.
    3. CSVReader needs more abstraction. What happens if file format is changed (xml)? 
4. Coding style is not consistent. Use of interpolation sometimes, sometimes concatenation. 
5. No support to different environments
6. How to add countries?
7. No parameters validation for public members
***

1. Quite carefully approach to write comments
2. Use of framework instead of direct writing to a file
3. Use of contracts
4. Unit tests
    