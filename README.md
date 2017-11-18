# WriteLogAutomationDemo
In the WriteLogAutomationDemo folder is a C# program, external to WriteLog, that demonstrates both automating WriteLog and monitoring WriteLog.
It makes no attempt to exhaustively cover all <a href="http://writelog.com">WriteLog</a>'s automation features, but it does show how to get
started; how to connect to a WriteLog instance in various ways, how to obtain interfaces to WriteLog's various
automation servers and callbacks, and how to call at least one method on each.

Both the <a href='http://writelog.com/demo'>demo</a> and <a href='http://writelog.com/ordering'>full</a> versions of WriteLog support the automation interfaces used here. 

Much of WriteLog's automation interface has been in <a href="https://writelog.com/notes/revision-history-version-12">WriteLog versions</a>
since the first of the WriteLog version 11 series. 
But certain features in this demo require 12.15 or later (again, either the demo or full WriteLog install.) This demo
source code is commented for the features that require the latest WriteLog.

#VbWlClient2
In the VbWlClient2 folder is a Visual Basic program that also demostrates automating WriteLog. It uses the 
focus notification object added to WriteLog version 12.23
