# Dr. Prepper

## Filename prepper for SharePoint

![Dr Prepper](https://github.com/akmatsu/dr-prepper/raw/master/images/screenshot.png "Dr Prepper")

### How it works

Starting from a specified base folder it: 
* recursively checks filenames for special characters or invalid strings (~ # % & { } + or .. ) 
* * All other disallowed characters are already disallowed by Windows.
* shows a preview of the files that will be renamed, 
* then renames the files appropriately. 

### File/Folder names cannot contain these characters
* Tilde (~)
* Number sign (#)
* Percent (%)
* Ampersand (&)
* Asterisk (*)
* Braces ({ })
* Backslash (\\)
* Colon (:)
* Angle brackets (< >)
* Question mark (?)
* Slash (/)
* Plus sign (+)
* Pipe (|)
* Quotation mark (")

### There are also restrictions about the position of a character in a file/folder name:
* A file/folder name cannot contain consecutive periods (..).
* A file/folder name cannot start with a period.
* A file/folder name cannot end with a period.

