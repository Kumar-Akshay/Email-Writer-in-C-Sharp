# Email-Writer-in-C-Sharp

Write a windows form application where user can write an email through a UI. User would be able to write the ‘To email address’, ‘Subject’ and ‘Message’ to send. Once the user has filled-in all of the details, he or she will press the send button, which will generate an XML file per email. Make sure, user should may not accidently press the submit button twice. All of the xml files will be stored in a folder defined in the configuration file (app.config) . XML output format will be as following:
<EmailMessage> 
<To>  </To>
<Subject> </Subject>
<MessageBody> </MessageBody>
</EmailMessage>
