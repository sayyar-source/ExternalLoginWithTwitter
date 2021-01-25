Authentication Using Twitter In ASP.NET Core 3.1
we want our users to log in using their existing credentials from Twitter In this article, we are going to look into authentication of an ASP.NET Core app using Twitter.

Note the URL from the browser address bar. In this case, the URL is http://localhost:51763/. We need this URL to configure our Twitter App, which we will be doing in the next section.

**Create the Twitter App**

Before we start building our ASP.NET Core 2.0 application, we need to create and configure the Twitter app so that we can use it to authenticate our application.

Navigate to https://apps.twitter.com/ and sign in using your existing Twitter account. If you do not have a Twitter account, you need to create one. You cannot proceed without a Twitter account. Once you have logged in, you will be redirected to an Application Management page similar to the one shown below.

![DhLIHOx6mS78mT2H-PsVCz5l7lDLfIiaZ8hc](https://user-images.githubusercontent.com/34911292/105683500-bf5d4200-5f04-11eb-95d7-4b4b2e9f2bb3.png)

You can fill the form filde.

<img width="497" alt="22" src="https://user-images.githubusercontent.com/34911292/105684547-2c250c00-5f06-11eb-8c05-2968bdb763e1.png">

Website:

Give your public website URL. But for this demo purpose, we will use a dummy URL http://demopage.com.

Callback URL:

Give the base URL of your application with /signin-twitter appended to it. For this tutorial, the URL will be http://localhost:5001/signin-twitter.

Navigate to the “Keys and Access Tokens” tab and make a note of the Consumer Key (API Key) and Consumer Secret (API Secret) field values. We will be using these values in the ASP.NET Core app.
