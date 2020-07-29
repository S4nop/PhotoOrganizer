# Auto Photo Organizer  
This code is for organizing pictures automatically according to the date.  
Written by C#, works on windows  

---

## Code Structure  
### frmMain.cs
A form that's responsible for almost everything.  
  
  `void BtnSelFolder_Click` : 'BtnSelFolder' button's click event listner. 
  Shows path selection dialog and reads image/video lists by calling `getFileList` function.  

`void init` : Init image list  

`void getFileList` : Read image/photo lists and their writeTime using  

`System.IO.FileInfo` and `getFileInf` function.  

`void ShowPicture` : Show preview of selected image by calling `frmPrev`  

  `void LstList_MouseDoubleClick` : 'LstList' list's double click event listener. 
  call `ShowPicture` function submitting selected image's path as a parameter.  

`void mov2Folder` : move selected file into target folder  

`fileInf getFileInf` : get file's writeTime using `FileInfo`  

`void categorize` : main function of this code. organizes images/videos  

`void lockAll/unlockAll` : lock/unlock all components in this form according to mode.  

```CSharp
class fileInf{
    private string year;
    private string month;
    private string date;
    ..
}
```
Class to manage image/video file's writeTime data
### frmPrev
Form to show image preview.  
`void showPhoto` : Load image using 'imgPrev' component  

### frmProg  
Form to show progressbar while working in the main form.  
`void update` : update progressbar.