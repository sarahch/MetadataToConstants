# Dynamics CRM metadata constants

Whenever I create new Dynamics CRM Plugins, I like to have constants files so that I can use intellisense and not fat finger the names of any of the Dynamics entities, attributes, optionset items, etc. I often wished I had written this tool sooner. 

Version 1.0.0.0 just takes the customizations.xml file from your exported solution and builds C# constants files from it. I just got it working, so I haven't gone back to refactor for best practices yet. Also, you will need to extract the files from the solution zip file, and make sure you included ALL the attributes you want in your constants file.