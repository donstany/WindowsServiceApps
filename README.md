Spy Windows Service
===================

Info about App:

Windows Service that monitor folder and write log 
with information about last modified files.

====================
Installation:

1. Run command prompt as administrator and write > installutil SpyService;

2. If installutil is not in system variable path add it System/Advanced Settings/Envoirnment Variables and add to Path folder where is located file installutil.exe;

3. Run /push button Windows+R/ services.msc and mark SpyService, from Properties choose Log on, Log As System Local check two check box.
4. Start service.

5. The default path for monitoring is C:\Users\User\Desktop\monitorSevice\monitor,
  and default log.txt is C:\Users\User\Desktop\monitorSevice, all path can be specicified by user.
 
