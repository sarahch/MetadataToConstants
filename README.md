# Dynamics CRM metadata constants

Whenever I create new Dynamics CRM Plugins, I like to have constants files so that I can use intellisense and not fat finger the names of any of the Dynamics entities, attributes, optionset items, etc. I often wished I had written this tool sooner. 

Version 1.0.0.0 just takes the customizations.xml file from your exported solution and builds C# constants files from it. I just got it working, so I haven't gone back to refactor for best practices yet. Also, you will need to extract the files from the solution zip file, and make sure you included ALL the attributes you want in your constants file.

Why not just use the code gen tools from CRM's SDK bin folder? My goal is to build an arsenal of tools that can be tweaked/updated easily as I need them. The tools in the CRM SDK have very little documentation, and they don't provide access to the code solution file. I could take this tool and update it to export customizations documentation instead. (Hmm... maybe that's next.)

When Microsoft removes the Organization service in the next release or two, the SDK samples could be released at a later date (as has happened in the past). This tool will continue work since it uses the XML from the customizations export. Eventually, I may add the new service, but hopefully Microsoft will provide that code for me. Lazy? Perhaps. But I have blogging to do. ;)
