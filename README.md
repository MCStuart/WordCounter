# Authors
## **Stuart McKay**

### Built With
* C#
* .Net Core
* MS Test
* Atom
* Git

### Friday Project (Week 6)
This project will demonstrate fundamental understanding of core concepts learned during the first week of C#

### Program Setup Instructions
1.


### Troubleshooting
Try turning it off and then on again

### License
This work is the sole ownership of the Authors'. Distribution is permitted under AGPLV3.

### Acknowledgments
* Thank you to the Epicodus staff for getting me this far.
* Stack Overflow
* GitHub
* My three partners this week
* Any others not specifically mentioned by name.

### Behavioral Driven Development Steps:
| Behavior | Input | Output | Reasoning |
| ------------- |:-------------:| :-------------:| -------: |  
| Tells you if a single character matches with another value or not | 'a' == 'a' | true | The simplest test case, evaluating whether a single character can recognize itself in another value field |

| Detects an input value inside another more complex value and returns frequency of that occurrence | "a" == "az" ? | 1 | Introduces looping for a, still, very simple test case through a more complex test case |

| Can detect multiple instances of a comparator value inside another value | "a" --> "asdfwasd" | 2 | Build off the looping and starts counting 'true' instances of the comparator |

| Tells you if a single word matches with another value or not | "word" == "word" | true | Increases complexity from single characters to a word |

| Returns the frequency of match cases of a word with a comparison value | "and" --> "Lions and tigers and bears" | 2 | Evaluates for a word now in a sentence |

| Returns only whole word exact matches without sub-word false positives | "and" --> "Bland sand and wand bands" | 1 | This will ensure that only true word matches are evaluated as true |
