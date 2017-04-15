$start_time = get-date
$version = "00.09.00a"
$ReleaseDate = "2014-10-20"
# Create Submittal out of Text Index.
#######
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
$scriptDir = "C:\\Sbin"
$scriptBin = "X:\\ELV-Subs"
Add-Type -Path "$scriptDir\\System.Data.SQLite.dll"
[System.Reflection.Assembly]::LoadWithPartialName('System.Windows.Forms')
cls
[Windows.Forms.MessageBox]::Show('New Datasheets has been released. You would have to Highlight the Datasheets yourselfs', 'Highlight Datasheets yourselves', [Windows.Forms.MessageBoxButtons]::OK, [Windows.Forms.MessageBoxIcon]::Information)
# index file path
$indexfile = "$home\desktop\index.txt"
$facpsimplex = "X:\ELV-Subs\facpsimplex\" # Folder path for Simplex datasheets
$mechdata = "X:\Mech-Subs\DATASHEET\" # Folder path for Mechanical datasheets
$facpsimplexcvr = "X:\ELV-Subs\facpsimplex\COVER\" # Folder path for Mechanical Covers
$mechcvr = "X:\Mech-Subs\COVER\" # Folder path for Simplex datasheets
$facpsimplexcdd = "X:\ELV-Subs\facpsimplex\CDD\" # Folder path for CDD documents
$mechcdd = "X:\Mech-Subs\CDD\" # Folder path for CDD documents
$facpsimplexul = "X:\ELV-Subs\facpsimplex\UL\" # Folder path for UL documents
$mechul = "X:\Mech-Subs\UL\" # Folder path for Mech UL documents
$facpsimplexfm = "X:\ELV-Subs\facpsimplex\FM\" # Folder path for FM documents
$mechfm = "X:\Mech-Subs\FM\" # Folder path for Mech FM documents
$mechkm = "X:\Mech-Subs\KM\" # Folder path for Mech KM documents
$mechvds = "X:\Mech-Subs\VDS\" # Folder path for Mech VDS documents
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
               $conn.close() #<<< FIX THIS THE CONNECTION SHOULD CLOSE
               return $datatSet.Tables[0].Rows
              
     }
     Export-ModuleMember -Variable * -Function *
} -asCustomObject
cls
$banner = "--------------------------Version:$version------------------FireLink--
--------------------Release Date:$ReleaseDate------------------FireLink--
            
Program to create Submittals

This version considers
1. All data sheets exists in the designated folder
2. Your Custom Files are on your desktop in folder name as Custom
3. This program only works on PDF files.
4. Operating system is Windows 7 or above
            
-----------------------------------------------------------------------
Please make sure
1. Your Index file is in text format and is on your desktop with name index.txt
---Known Bug----
1. Does not work work for a submittal of more than 350 Part Numbers
2. Password protected PDF are not allowed.
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
write-Host "Submittal System Type: `nPress: 1 For Submittal With Grouped AHJ & Third Party Documents  `nPress: 2 NOT IN USE--Possible use with Grouped Datasheet + AHJ Approval + Third Party Document `nPress: 3 For converting DOCX files to PDF `nPress: 4 For Creating Customs Clearance Documents `nPress: 5 For Mechanical System Submittal `nPress: 6 For Creating Mechanical Custom Clearance Documents" -foregroundcolor "GREEN" -backgroundcolor "BLUE"
$matindexfile = "$home\desktop\" + $new_project_name + "_MAT_INDEX" + '_' + $base_date + '.csv' ## Creating Material Index file name
$system_type = $host.UI.RawUI.ReadKey("Noecho,IncludeKeyDown")
$finalfile = "$home\Desktop\$new_project_name" + "_$base_date.pdf"
$finalfile = $finalfile.toupper()
[bool] $true_result = Test-Path -path $home\desktop\index.txt   ##- Check if the file exists in the correct place
if((Get-childItem $indexfile -name) -eq "index.txt" )
{
	switch($system_type.character)
     {
    '1' #<< use switch Creating FACP Simplex Submittal
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
    '2' #<< use switch
               {
                  write-host "Not in Use"

				}
    '3' 
               {
                    start-process -filepath "X:\ELV-Subs\om1.ps1" -wait
                    explorer $customfldr
               }
	'4'	 { #custom clearance documents
			  Out-file -Encoding ASCII -inputobject "S.NO,PART NO,DESCRIPTION,CDD NUMBER,UL FILE NUMBER,EXPIRY DATE" -force -filepath $matindexfile   ## Creating Material Index file
			  write-host "`nIndex File Found, Now Creating Custom Clearance documents`nPlease Wait....."
			  $file_list = get-content -Path $indexfile
			  ##--- Searching for the Part numbers ------------#
			  foreach($new_file_name_temp in $file_list) #-- Here we go to loop for Datasheet
						   {
								  $readQuery = "SELECT url,cover,cdd,tittle,cddno,ul,expirydt FROM simplex where partno='$new_file_name_temp'"
								  $dataArray = $SQLite.querySQLite($readQuery)
								  Out-file -Encoding ASCII -inputobject "Part Number is:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
								  Out-file -Encoding ASCII -inputobject "Query is: $readQuery" -append -filepath X:\ELV-Subs\log\$activity_log
								  if($dataArray)
								  {
									# read-host "Press any key to continue"
									# >>>>>>>> add check for invalid file name
									[string] $compilefilessimplex += " " + "$facpsimplex" + $dataArray['url'] + ".pdf" + " " + "$facpsimplexcdd" + $dataArray['cdd'] + ".pdf" + " " + "$facpsimplexul" + $dataArray['ul'] + ".pdf"
									$description = $dataArray['tittle'] ## Descrption of the part number
									$cddno = $dataArray['cddno'] ## CDD File Number
									$ul = $dataArray['ul'].replace("-UL","") ## UL File Number
									$expirydt = $dataArray['expirydt'] ## Expiry Date
									Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,$description,$cddno,$ul,$expirydt" -append -filepath $matindexfile   
									}else{
									write-warning "Part Number $new_file_name_temp Not In Database, Please Insert Manually"
									Out-file -Encoding ASCII -inputobject "Part Number Not Found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log                        
									}
									$counterA += 1  
							}
			 #WRITE-HOST $compilefilessimplex
								Out-file -Encoding ASCII -inputobject "$compilefilessimplex" -append -filepath X:\ELV-Subs\log\$activity_log    
							  # creatting the string of files to be compiled
							  # X:\ELV-Subs\bin\pdftk.exe $sumcompile output $home\Desktop\$new_project_name$date
							  $arguments = "$compilefilessimplex output $finalfile"
							  start-process -filepath "X:\ELV-Subs\bin\pdftk.exe" $arguments -wait -NoNewWindow
							  # X:\ELV-Subs\bin\pdftk.exe $finalfile update_info X:\ELV-Subs\bin\meta.nfo
							  if((Get-childItem $home\Desktop -name) -eq ("$new_project_name" + "_$base_date.pdf") ) ## Checking if the document has been created
								   {
										$end_time = get-date
										$totaltime = $end_time - $start_time
										Write-host "Total time for creating document :$totaltime" -foregroundcolor "GREEN" -backgroundcolor "BLUE"
										Out-file -Encoding ASCII -inputobject "File Created at $finalfile" -append -filepath X:\ELV-Subs\log\$activity_log    
										explorer $finalfile # >>>>>>>> add check for if file exist
									}	
		}
	'5'	 {#Mechanical submittal with clubbed ul,fm,km and vds 
		         Out-file -Encoding ASCII -inputobject "S.NO,PART NO,DESCRIPTION,CDD NUMBER,UL FILE NUMBER,FM ,KITEMARK,VDS,EXPIRY DATE" -force -filepath $matindexfile   ## Creating Material Index file
          write-host "`nIndex File Found, Now Creating Mechanical Submittal `nPlease Wait....."
          $file_list = get-content -Path $indexfile
          ##--- Searching for the Part numbers ------------#
          foreach($new_file_name_temp in $file_list) #-- Here we go to loop for Datasheet
                       {
                              $readQuery = "SELECT url,cover,tittle,cddno,ul,fm,km,vds,expirydt FROM mech where partno='$new_file_name_temp'"
                              $dataArray = $SQLite.querySQLite($readQuery)
							  Out-file -Encoding ASCII -inputobject "Part Number is:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
							  Out-file -Encoding ASCII -inputobject "Query is: $readQuery" -append -filepath X:\ELV-Subs\log\$activity_log
							  if($dataArray)
							  {
								# read-host "Press any key to continue"
								# >>>>>>>> add check for invalid file name
								[string] $compilefilessimplex += " " + "$mechcvr" +  $dataArray['cover'] + ".pdf" + " " + "$mechdata" + $dataArray['url'] + ".pdf"
								$partnolist += "'"+ $dataArray['url']+"',"
								# WRITE-HOST $compilefiles
								$description = $dataArray['tittle'] ## Descrption of the part number
								$cddno = $dataArray['cddno'] ## CDD File Number
								$ul = $dataArray['ul'].replace("-UL","") ## UL File Number
								$fm = $dataArray['fm'].replace("-FM","") ## FM Number
								$km = $dataArray['km'].replace("-KM","") ## KM Number
								$vds = $dataArray['vds'].replace("-VDS","") ## VDS Number
								$expirydt = $dataArray['expirydt'] ## Expiry Date
								Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,$description,$cddno,$ul,$fm,$km,$vds,$expirydt" -append -filepath $matindexfile                             
								}else{
								write-warning "Part Number $new_file_name_temp Not In Database, Please Insert Manually"
								Out-file -Encoding ASCII -inputobject "Part Number Not Found:$new_file_name_temp" -append -filepath X:\ELV-Subs\log\$activity_log
								Out-file -Encoding ASCII -inputobject "$counterA,$new_file_name_temp,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE,NOT IN DATABASE" -append -filepath $matindexfile                             
								}
								$counterA += 1                            
                       }
                       # get the CDD Documents grouped
                       $readcdd = "SELECT cdd FROM mech where partno in($partnolist) group by cdd"
					    $readcdd = $readcdd.replace(",)",")")
                       Out-file -Encoding ASCII -inputobject "CDD Grouping as:$readcdd" -append -filepath X:\ELV-Subs\log\$activity_log
                       $dataArraycdd = $SQLite.querySQLite($readcdd) 
                       if ($dataArraycdd -isnot [system.array]){$dataArrayvcdd = @($dataArraycdd)} ## Checks for single rows and null arrays this is a Bug fix
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
                                                       [string] $compilefilescdd += " " + "$mechcdd" + $targetcddfile + ".pdf"
                                                       }
                                        $counterB += 1
                                       }
                       # get the third party certs grouped
					   #GET UL
		               $readul = "SELECT ul FROM mech where partno in($partnolist) group by ul"
                       $readul = $readul.replace(",)",")")
					   Out-file -Encoding ASCII -inputobject "Ul Grouping as:$readul" -append -filepath X:\ELV-Subs\log\$activity_log
                       $dataArrayul = $SQLite.querySQLite($readul)
   					   if ($dataArrayul -eq $null ){write-host  "GOT IT $dataArrayul" $dataArrayul = @(1,'NA')}
					   elseif ($dataArrayul -isnot [system.array]){$dataArrayul = @($dataArrayul)} ## Checks for single rows and null arrays this is a Bug fix
            			foreach ($readultemp in $dataArrayul)
                                   {
                               $targetulfile = $dataArrayul["$counterC"]['ul']
                                      If($targetulfile -eq 'NA')
                               {
                               Out-file -Encoding ASCII -inputobject "NO UL serial number: $counterC" -append -filepath X:\ELV-Subs\log\$activity_log
                               }
                               else{
                                    Out-file -Encoding ASCII -inputobject "Getting UL:$targetulfile" -append -filepath X:\ELV-Subs\log\$activity_log    
                                            [string] $compilefilesul += " " + "$mechul" + $targetulfile + ".pdf" #ul list files
                                            }
                                   $counterC += 1
                                   }
						[int] $counterC = 0					  
					  #Group FM
					   $readfm = "SELECT fm FROM mech where partno in($partnolist) group by fm"
                       $readfm = $readfm.replace(",)",")")
					   Out-file -Encoding ASCII -inputobject "FM Grouping as:$readfm" -append -filepath X:\ELV-Subs\log\$activity_log
					   $dataArrayfm = $SQLite.querySQLite($readfm) 
  					   if ($dataArrayfm -eq $null ){write-host  "GOT IT $dataArrayfm" $dataArrayfm = @(1,'NA')}
					   elseif ($dataArrayfm -isnot [system.array]){$dataArrayfm = @($dataArrayfm)} ## Checks for single rows and null arrays this is a Bug fix
						foreach ($readfmtemp in $dataArrayfm)
                                   {
                               $targetfmfile = $dataArrayfm["$counterC"]['fm']
                                      If($targetfmfile -eq 'NA')
                               {
                               Out-file -Encoding ASCII -inputobject "NO fm serial number: $counterC" -append -filepath X:\ELV-Subs\log\$activity_log
                               }
                               else{
                                    Out-file -Encoding ASCII -inputobject "Getting fm:$targetfmfile" -append -filepath X:\ELV-Subs\log\$activity_log    
                                            [string] $compilefilesfm += " " + "$mechfm" + $targetfmfile + ".pdf" #FM list files
                                            }
                                   $counterC += 1
                                   }
						[int] $counterC = 0	
					   #Group KM
					   $readkm = "SELECT km FROM mech where partno in($partnolist) group by km"
                       $readkm = $readkm.replace(",)",")")
					   Out-file -Encoding ASCII -inputobject "KM Grouping as:$readkm" -append -filepath X:\ELV-Subs\log\$activity_log
                       $dataArraykm = $SQLite.querySQLite($readkm) # >>>>>>>> add check for no return
					   if ($dataArraykm -eq $null ){write-host  "GOT IT $dataArraykm" $dataArraykm = @(1,'NA')}
					   elseif ($dataArraykm -isnot [system.array]){$dataArraykm = @($dataArraykm)} ## Checks for single rows and null arrays this is a Bug fix
                       foreach ($readkmtemp in $dataArraykm)
                                   {
                               $targetkmfile = $dataArraykm["$counterC"]['km']
                                      If($targetkmfile -eq 'NA')
                               {
                               Out-file -Encoding ASCII -inputobject "NO km serial number: $counterC" -append -filepath X:\ELV-Subs\log\$activity_log
                               }
                               else{
                                    Out-file -Encoding ASCII -inputobject "Getting km:$targetkmfile" -append -filepath X:\ELV-Subs\log\$activity_log    
                                            [string] $compilefileskm += " " + "$mechkm" + $targetkmfile + ".pdf" #KM list files
                                            }
                                   $counterC += 1
                                   }
						[int] $counterC = 0	
					   #Group VDS
					   $readvds = "SELECT vds FROM mech where partno in($partnolist) group by vds"
                       $readvds = $readvds.replace(",)",")")
					   Out-file -Encoding ASCII -inputobject "VDS Grouping as:$readvds" -append -filepath X:\ELV-Subs\log\$activity_log
					   $dataArrayvds = $SQLite.querySQLite($readvds) # >>>>>>>> add check for no return
					   if ($dataArrayvds -eq $null ){write-host  "GOT IT $dataArrayvds" $dataArrayvds = @(1,'NA')}
					   elseif ($dataArrayvds -isnot [system.array]){$dataArrayvds = @($dataArrayvds)} ## Checks for single rows and null arrays this is a Bug fix
                       foreach ($readvdstemp in $dataArrayvds)
                                   {
                               #write-host  "THE VDS IS $readvdstemp"
							   $targetvdsfile = $dataArrayvds["$counterC"]['vds']
                           If($targetvdsfile -eq 'NA')
                               {
                               Out-file -Encoding ASCII -inputobject "NO vds serial number: $counterC" -append -filepath X:\ELV-Subs\log\$activity_log
                               }
                               else{
                                    Out-file -Encoding ASCII -inputobject "Getting vds:$targetvdsfile" -append -filepath X:\ELV-Subs\log\$activity_log    
                                            [string] $compilefilesvds += " " + "$mechvds" + $targetvdsfile + ".pdf" #VDS list files
                                            }
                                   $counterC += 1
                                   }
						[int] $counterC = 0						   
                        [string] $sumcompile = $doccover + $compilefilessimplex + $certcover + $compilefilescdd + $compilefilesul + $compilefilesfm  + $compilefileskm + $compilefilesvds      
          # WRITE-HOST $sumcompile
          Out-file -Encoding ASCII -inputobject "$sumcompile" -append -filepath X:\ELV-Subs\log\$activity_log    
          # creatting the string of files to be compiled
          # X:\ELV-Subs\bin\pdftk.exe $sumcompile output $home\Desktop\$new_project_name$date
          $arguments = "$sumcompile output $finalfile"
          start-process -filepath "X:\ELV-Subs\bin\pdftk.exe" $arguments -wait -NoNewWindow
          # X:\ELV-Subs\bin\pdftk.exe $finalfile update_info X:\ELV-Subs\bin\meta.nfo
          if((Get-childItem $home\Desktop -name) -eq ("$new_project_name" + "_$base_date.pdf") ) ## Checking if the document has been created
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
		
		default		{
				   $warning_msg = $system_type.character + " Not implemented yet"
				   write-warning $warning_msg
				   }
      }
}else{
     cls
    write-warning "`n Please check your Index file, it does not exists `n Re-run the program after placing index.txt on your Desktop"
# $run_time = $end_time.minute - $start_time.minute
}
Out-file -Encoding ASCII -inputobject "----------------Closing Log file for project name $new_project_name at $end_time Run Time:$totaltime" -append -filepath X:\ELV-Subs\log\$activity_log
Write-host "Press any Key to exit...."
$pause = $host.UI.RawUI.ReadKey("Noecho,IncludeKeyDown")