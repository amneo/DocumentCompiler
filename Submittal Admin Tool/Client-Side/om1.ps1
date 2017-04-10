$start_time = get-date
$version = "00.08.07a"
# Create Submittal out of Text Index.
#######
#Date: 2013-05-22
# OS and Environment limitation.
# .net 3.5 or above
# Powershell 1.0 or above
# Windows 7 and above
# .Net 3.5
#######
####     1. Features
## 1.1 Read the part number from index file stored on user's desktop
#####     2.     Variables
##     2.1 $scriptDir user local folder that contains System.Data.SQLite Dll's
##     2.2 $indexfile Index source file for partnumbers
##     2.4     Array of Part numbers $file_list
##     2.5     Creating array of file names for join $index_file_join
##     2.6 Counter for temporary files of submittal this is being done as a work around for pdftk limitation $counterA
#####
## 3.Find files in $find_list from $fldr_src and subfolders
## 4.If single file found copy the file
####### Scrpt Wide Vazriables here
$scriptDir = "C:\Sbin"
$scriptBin = "X:\ELV-Subs"
Add-Type -Path "$scriptDir\System.Data.SQLite.dll"
[System.Reflection.Assembly]::LoadWithPartialName('System.Windows.Forms')
cls
[Windows.Forms.MessageBox]::Show('New Datasheets has been released by Simplex!. You would have to Highlight the Datasheets yourselfs', 'Highlight Datasheets yourselves', [Windows.Forms.MessageBoxButtons]::OK, [Windows.Forms.MessageBoxIcon]::Information)
# index file path
$indexfile = "$home\desktop\index.txt"
$facpsimplex = "X:\ELV-Subs\facpsimplex\" # Folder path for Simplex datasheets
$facpsimplexcvr = "X:\ELV-Subs\facpsimplex\COVER\" # Folder path for Covers
$facpsimplexcdd = "X:\ELV-Subs\facpsimplex\CDD\" # Folder path for CDD documents
$facpsimplexul = "X:\ELV-Subs\facpsimplex\UL\" # Folder path for UL documents
$facpsimplexfm = "X:\ELV-Subs\facpsimplex\FM\" # Folder path for FM documents
$certcover = " X:\ELV-Subs\facpsimplex\COVER\CERTS-COVER.pdf" # Cover for Certificates cover
$doccover = "X:\ELV-Subs\facpsimplex\COVER\SUB-COVER-R2.pdf" # Cover for the document
$customfldr = "$home\desktop\Custom\"
##For log file
$base_date = get-date -uFormat "%Y-%m-%d_%H_%M_%S"
$user_name = $home.replace("\","-")
$user_name = $user_name.replace(":","-")
$activity_log = $base_date + '_' + $user_name + '.txt'
Out-file -Encoding ASCII -inputobject "----------------Initiating Log file at $base_date by user $user_name" -force -filepath X:\ELV-Subs\log\$activity_log
## Declaring the home folder for desktop as default location
##### Variables end
$SQLite = New-Module {

     Function querySQLite {
          param([string]$query)
                    ### declare location of db file. ###
                    $database = "X:\ELV-Subs\elv-subm"
               $datatSet = New-Object System.Data.DataSet
               $connStr = "Data Source = $database"
               $conn = New-Object System.Data.SQLite.SQLiteConnection($connStr)
               $conn.Open()
               $dataAdapter = New-Object System.Data.SQLite.SQLiteDataAdapter($query,$conn)
               [void]$dataAdapter.Fill($datatSet)
               # $conn.close()
               return $datatSet.Tables[0].Rows
             
     }
   
     Function writeSQLite {
          param([string]$query)
        
               $database = "$scriptDir\data"
               $connStr = "Data Source = $database"
               $conn = New-Object System.Data.SQLite.SQLiteConnection($connStr)
               $conn.Open()
               $command = $conn.CreateCommand()
               $command.CommandText = $query
               $RowsInserted = $command.ExecuteNonQuery()
               $command.Dispose()
     }
   
     Export-ModuleMember -Variable * -Function *
} -asCustomObject
# cls
$banner = "--------------------------Version:$version------------------FireLink--
           
Program to create ELV Submittal

This version considers
1. All data sheets exists in the designated folder
2. Your Custom Files are on your desktop in folder name as Custom
3. This program only works on PDF files.
4. Operating system is Windows 7 or above
           
-----------------------------------------------------------------------
Please make sure
1. Your Index file is in text format and is on your desktop with name index.txt
---Known Bug----
1. Does not work for a Single Part Number but only works for more than one part number in Index.txt file that has diffrent UL and CDD Files.
2. Does not work work for a submittal of more than 350 Part Numbers

-------------------------------------------------------Vishal Kashyap
"
write-host $banner
write-Host "`nUSE AT YOUR OWN RISK. HIGHLIGHT THE DATASHEET YOURSELVES" -foregroundcolor "WHITE" -backgroundcolor "RED"
[int] $counterA = 0
[int] $counterB = 0
[int] $counterC = 0
##[array] $index_file_join
write-Host "`nProject name Without white space and special characters:$new_project_name" -foregroundcolor "WHITE" -backgroundcolor "BLACK"
$new_project_name = Read-Host "Key in Project Name"
$new_project_name = $new_project_name.REPLACE(" ",'')
$new_project_name = $new_project_name.TRIM()
if (($new_project_name.Length) -gt 4)
     {
     $new_project_name = $new_project_name.Substring(0,5)
     }
write-Host "Project Name Pre-fix: `n$new_project_name" -foregroundcolor "WHITE" -backgroundcolor "BLACK"
write-Host "Submittal System Type: `nPress: 1 For Simplex Submittal`nPress: 2 For Custom Submittal `nPress: 3 For converting DOCX files to PDF `nPress: 4 For Creating Simplex Custom Clearance Documents `nPress: 5 For Mechanical System Submittal `nPress: 6 For Creating Mechanical Custom Clearance Documents" -foregroundcolor "GREEN" -backgroundcolor "BLUE"
$matindexfile = "$home\desktop\" + $new_project_name + "_MAT_INDEX" + '_' + $base_date + '.csv' ## Creating Material Index file name
$system_type = $host.UI.RawUI.ReadKey("Noecho,IncludeKeyDown")
$finalfile = "$home\Desktop\$new_project_name" + "_$base_date.pdf"
$finalfile = $finalfile.toupper()
[bool] $true_result = Test-Path -path $home\desktop\index.txt   ##- Check if the file exists in the correct place
if((Get-childItem $indexfile -name) -eq "index.txt" )
{
     #Creating FACP Simplex Submittal
     if($system_type.character -eq '1') #<< use switch
          {
          Out-file -Encoding ASCII -inputobject "S.NO,PART NO,DESCRIPTION,CDD NUMBER,UL FILE NUMBER,EXPIRY DATE" -force -filepath $matindexfile   ## Creating Material Index file
          write-host "`nIndex File Found, Now Creating Simplex Submittal `nPlease Wait....."
          $file_list = get-content -Path $indexfile
          ##--- Searching for the Part numbers ------------#
          foreach($new_file_name_temp in $file_list) #-- Here we go to loop for Datasheet
                       {
                              $readQuery = "SELECT url,cover,tittle,cddno,ul,expirydt FROM simplex where partno='$new_file_name_temp'"
                              $dataArray = $SQLite.querySQLite($readQuery)
                                     Out-file -Encoding ASCII -inputobject "Part Number is:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                     Out-file -Encoding ASCII -inputobject "Query is: $readQuery" -append -filepath X:\ELV-Subs\log\$activity_log
                                     if($dataArray)
                                     {
                                        # read-host "Press any key to continue"
                                        # >>>>>>>> add check for invalid file name
                                        [string] $compilefilessimplex += " " + "$facpsimplexcvr" +  $dataArray['cover'] + ".pdf" + " " + "$facpsimplex" + $dataArray['url'] + ".pdf"
                                        $partnolist += "'"+ $dataArray['url']+"',"
                                        # WRITE-HOST $compilefiles
                                        $description = $dataArray['tittle'] ## Descrption of the part number
                                        $cddno = $dataArray['cddno'] ## CDD File Number
                                        $ul = $dataArray['ul'].replace("-UL","") ## UL File Number
                                        $expirydt = $dataArray['expirydt'] ## Expiry Date
                                        Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,$description,$cddno,$ul,$expirydt" -append -filepath $matindexfile                            
                                        }else{
                                        write-warning "Part Number $new_file_name_temp Not In Database, Please Insert Manually"
                                        Out-file -Encoding ASCII -inputobject "Part Number Not Found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                        Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE" -append -filepath $matindexfile                            
                                        }
                                        $counterA += 1                           
                       }
                       # get the CDD Documents grouped
                       $readcdd = "SELECT cdd FROM simplex where partno in($partnolist) group by cdd"
                   $readcdd = $readcdd.replace(",)",")")
                       Out-file -Encoding ASCII -inputobject "CDD Grouping as:$readcdd" -append -filepath X:\ELV-Subs\log\$activity_log
                       $dataArraycdd = $SQLite.querySQLite($readcdd) # >>>>>>>> add check for no return
                    # Echo "array is" $dataArraycdd['0']['cdd']
                            foreach ($readcddtemp in $dataArraycdd)
                                       {
                                            $targetcddfile = $dataArraycdd["$counterB"]['cdd']
                                             if($targetcddfile -eq 'NA')
                                                  {
                                                  Out-file -Encoding ASCII -inputobject "NO CDD for serial number: $counterB" -append -filepath X:\ELV-Subs\log\$activity_log
                                                  }else{
                                                       # Echo "array is" $dataArraycdd["$counterB"]['cdd']
                                                       Out-file -Encoding ASCII -inputobject "Getting CDD:$targetcddfile" -append -filepath X:\ELV-Subs\log\$activity_log                       
                                                       [string] $compilefilescdd += " " + "$facpsimplexcdd" + $targetcddfile + ".pdf"
                                                       }
                                        $counterB += 1
                                       }
                       # get the UL certs grouped
                       $readul = "SELECT ul FROM simplex where partno in($partnolist) group by ul"
                       $readul = $readul.replace(",)",")")
                       Out-file -Encoding ASCII -inputobject "Ul Grouping as:$readul" -append -filepath X:\ELV-Subs\log\$activity_log
                       $dataArrayul = $SQLite.querySQLite($readul) # >>>>>>>> add check for no return
                    foreach ($readultemp in $dataArrayul)
                                   {
                               $targetulfile = $dataArrayul["$counterC"]['ul']
                                      If($targetulfile -eq 'NA')
                               {
                               Out-file -Encoding ASCII -inputobject "NO UL serial number: $counterC" -append -filepath X:\ELV-Subs\log\$activity_log
                               }
                               else{
                                    Out-file -Encoding ASCII -inputobject "Getting UL:$targetulfile" -append -filepath X:\ELV-Subs\log\$activity_log   
                                            [string] $compilefilesul += " " + "$facpsimplexul" + $targetulfile + ".pdf"
                                            }
                                   $counterC += 1
                                   }
                    [string] $sumcompile = $doccover + $compilefilessimplex + $certcover + $compilefilescdd + $compilefilesul           
          # WRITE-HOST $sumcompile
          Out-file -Encoding ASCII -inputobject "$sumcompile" -append -filepath X:\ELV-Subs\log\$activity_log   
          # creatting the string of files to be compiled
          # X:\ELV-Subs\bin\pdftk.exe $sumcompile output $home\Desktop\$new_project_name$date
          $arguments = "$sumcompile output $finalfile"
          start-process -filepath "X:\ELV-Subs\bin\pdftk.exe" $arguments -wait -NoNewWindow
          # X:\ELV-Subs\bin\pdftk.exe $finalfile update_info X:\ELV-Subs\bin\meta.nfo
          if((Get-childItem $home\Desktop -name) -eq ("$new_project_name" + "_$base_date.pdf") ) ## Checking if the documkent has been created
               {
                    $end_time = get-date
                    $totaltime = $end_time - $start_time
                    Write-host "Total time for creating document :$totaltime" -foregroundcolor "GREEN" -backgroundcolor "BLUE"
                    Out-file -Encoding ASCII -inputobject "File Created at $finalfile" -append -filepath X:\ELV-Subs\log\$activity_log   
                    explorer $finalfile # >>>>>>>> add check for if file exsist
               }else{
                    Write-host "Could not create Submittal Speak to Vishal" -foregroundcolor "RED" -backgroundcolor "WHITE"
                      }
          }
          elseif($system_type.character -eq '2') #<< use switch
               {
               $file_list = get-content -Path $indexfile
               write-host "`nIndex File Found, Now Creating Custom Submittal `nEnsure all files are in your custom folder`nPlease Wait....."
               foreach($new_file_name_temp in $file_list) #-- Here we go to loop for Datasheet in custom folder
                       {
                              # $check_file = "$home\desktop\custom\$new_file_name_temp" + ".pdf"
                              # write-host "checking for file $check_file"
                              if(Test-Path -Path $home\desktop\custom\$new_file_name_temp.pdf)##replace with interactive later
                                   {
                                   Out-file -Encoding ASCII -inputobject "File Sequence found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                   # read-host "Press any key to continue"
                                   # >>>>>>>> add check for invalid file name
                                   write-host "In loop when document found"
                                   [string] $compilefilescustom += " " + $customfldr + $new_file_name_temp + ".pdf"
                                 }
                                 else{
                                        Out-file -Encoding ASCII -inputobject "File Sequence Not found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                        [string] $compilefilescustom += " " + $new_file_name_temp + ".pdf"
                                        Write-host "Could not find file $new_file_name_temp.pdf `n`nPress any key to quite and restart after placing the file..." -foregroundcolor "RED" -backgroundcolor "WHITE"
                                 $pause = $host.UI.RawUI.ReadKey("Noecho,IncludeKeyDown")
                                 exit
                                 }                          
                         # write-host "out of check path folder"
                         }
                         Out-file -Encoding ASCII -inputobject "$compilefilescustom" -append -filepath X:\ELV-Subs\log\$activity_log   
               # creatting the string of files to be compiled
               $arguments = "$compilefilescustom output $finalfile"
               start-process -filepath "X:\ELV-Subs\bin\pdftk.exe" $arguments -wait -NoNewWindow
               # X:\ELV-Subs\bin\pdftk.exe $finalfile update_info X:\ELV-Subs\bin\meta.nfo
                    if((Get-childItem $home\Desktop -name) -eq ("$new_project_name" + "_$base_date.pdf") ) ## Checking if the documkent has been created
                         {
                              $end_time = get-date
                              $totaltime = $end_time - $start_time
                              Write-host "Total time for creating document :$totaltime" -foregroundcolor "GREEN" -backgroundcolor "BLUE"
                              Out-file -Encoding ASCII -inputobject "File Created at $finalfile" -append -filepath X:\ELV-Subs\log\$activity_log   
                              explorer $finalfile # >>>>>>>> add check for if file exsist
                         }else{
                              Write-host "Could not create your custom Submittal Speak to Vishal" -foregroundcolor "RED" -backgroundcolor "WHITE"
                              Out-file -Encoding ASCII -inputobject "File did not create" -append -filepath X:\ELV-Subs\log\$activity_log
                                }
          }
          elseif($system_type.character -eq '3')
               {
                    start-process -filepath "X:\ELV-Subs\om1.ps1" -wait
                    explorer $customfldr
               }
                 elseif($system_type.character -eq '4')
                       {
                 Out-file -Encoding ASCII -inputobject "S.NO,PART NO,DESCRIPTION,CDD NUMBER,UL FILE NUMBER,EXPIRY DATE" -force -filepath $matindexfile   ## Creating Material Index file
                 write-host "`nIndex File Found, Now Creating Custom Clearance documents`nPlease Wait....."
                 $file_list = get-content -Path $indexfile
                 ##--- Searching for the Part numbers ------------#
                 foreach($new_file_name_temp in $file_list) #-- Here we go to loop for Datasheet
                                 {
                                          $readQuery = "SELECT url,cover,tittle,cddno,ul,expirydt FROM simplex where partno='$new_file_name_temp'"
                                          $dataArray = $SQLite.querySQLite($readQuery)
                                          Out-file -Encoding ASCII -inputobject "Part Number is:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                          Out-file -Encoding ASCII -inputobject "Query is: $readQuery" -append -filepath X:\ELV-Subs\log\$activity_log
                                          if($dataArray)
                                          {
                                             # read-host "Press any key to continue"
                                             # >>>>>>>> add check for invalid file name
                                             [string] $compilefilessimplex += " " + "$facpsimplexcvr" +  $dataArray['cover'] + ".pdf" + " " + "$facpsimplex" + $dataArray['url'] + ".pdf"
                                             $partnolist += "'"+ $dataArray['url']+"',"
                                             # WRITE-HOST $compilefiles
                                             $description = $dataArray['tittle'] ## Descrption of the part number
                                             $cddno = $dataArray['cddno'] ## CDD File Number
                                             $ul = $dataArray['ul'].replace("-UL","") ## UL File Number
                                             $expirydt = $dataArray['expirydt'] ## Expiry Date
                                             Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,$description,$cddno,$ul,$expirydt" -append -filepath $matindexfile                            
                                             }else{
                                             write-warning "Part Number $new_file_name_temp Not In Database, Please Insert Manually"
                                             Out-file -Encoding ASCII -inputobject "Part Number Not Found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
                                             Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE" -append -filepath $matindexfile                            
                                             }
                                             $counterA += 1 
                       }

               else{
               $warning_msg = $system_type.character + " Not implemented yet"
               write-warning $warning_msg
               }
}else{
     cls
    write-warning "`n Please check your Index file, it does not exists `n Re-run the program after placing index.txt on your Desktop"
# $run_time = $end_time.minute - $start_time.minute
}
Out-file -Encoding ASCII -inputobject "----------------Closing Log file for project name $new_project_name at $end_time Run Time:$totaltime" -append -filepath X:\ELV-Subs\log\$activity_log
Write-host "Press any Key to exit...."
$pause = $host.UI.RawUI.ReadKey("Noecho,IncludeKeyDown")