                                      Paras Electronics UltraSoic Flaw Detector(Hyderabad)
                                                      Model no 
                                                     Working Flow. 

Module1.Vb:

Chanels Are Decleared in the Top Of the Module in TotNch
The DataArr(TotalChannel,TotalParameter) (Main Channels Array)
The DataArr10(index,Parameter) (Store The 10 Channels Value in the Seperate Array to Write from the Config10, angle10 and Gain10)
The CalsetDataArr10(Calset,Parameter) The 10 Calset Values for the Array To maintain For All Purposes Based On CalsetDataArr()
Check the .Cnf Files For All the 10 Calsets form the Calibration Window.
Please Initialize The Global Functions and Variables to Use for All Forms.
Config, Angle And Gain File is Writing in the WriteIConfig(), SaveGain(), SaveAng()
OpenConfig() is the Function to Save the DataArr Values in the PRV & PRS Files To Read from the PC application.
SendGainset() Function is Controlling the ADC communication From The Appliction
LoadParams() Function is Loading the Parameters Of the Maximum KM and Required Parameters To Test.
SetVars() is used to Set the Colors Based on the Colors and Colorind
setConfig() it will Write the Cnf File At first Time While Delete All The Cnf Files from the ParaSRT Folder.
fngain10db() This Function will check for the C application is increased the Gain10DB from the Test Applicaton After Saving the Defects need to Change the Increased 10DB Value From the PRV and PRS files.
GetWaveAng(),Rangeml(),Rangemm() This function Will Calculate the Anngle And Range Based on the Memory Locations.

Form 1: 

Startup window With the Initial Informations Like Model No, Machine No, Date & Time
Model.txt File Is giving the Modelno
It Contains The Navigation to the Other Forms.
Navigation Is Handled By the KeyDown Event.
Key1: Calling the TestSetup Window To set the Parameters For Testing the Defects.
Key2: Calling the Calibration Window to Set the Gain, Dely, Range, Rejection, G1st, G1end, Threshold1, G2st, G2End, Threshold2, Angle.
Key3: Calling the Open PRV & PRS Defects to View the PRV & PRS jpg Files and Date Sorting.
Key4: Calling the Color Window To Set the Color For the Particular Channels
Key5: Calling the Open Log Window To Transfer the LogFiles to the PenDrive.
Key6: Exit the Apllication.
Key7: Free
Key8: odoTest Application is calling To test the Encoder Rotation.
Key9: Free
Key10: Free

Form 2:
To Set the Testing Information of the Rail Tested

Add The Controls To ParasSRT Windows Forms Need To check Three Things
I. Check The SetTextBox Function For the Left Right Key with Curj and Uped Variables.
II. To Introduce the Up & Down Arrow Functionality Go to The KeyDown Event.
    Check For Up and Down with the respective Curj value in the Switch Case Statement.
III. Then Need to Call The Steps in the SaveKey From KeyDown Event.

The Form2 is Responsible For Storing the Testing Parameters By the User.