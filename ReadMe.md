Chat server design
--------------------

1.	Backend components:
·   	Database: A database is required to store user account information, chat room details, and message history.
·   	Authentication and authorization: A system to authenticate and authorize users based on their login credentials.
·   	Chat Room Manager: A component that manages the creation and deletion of chat rooms, as well as the adding and removing of users to/from chat rooms.
·   	Message Manager: A component that handles sending and receiving messages within the chat rooms.
·   	Notification Manager: A component that sends notifications to users when they receive a new message.
2.	Classes:
·   	User: This class represents a user account, with properties such as username, password, and email address.
·   	Chat Room: This class represents a chat room, with properties such as room name and list of users.
·   	Message: This class represents a chat message, with properties such as sender, recipient, and message content.
3.	Methods:
·   	User authentication and registration methods, such as RegisterUser, AuthenticateUser, and LogoutUser.
·   	Chat room management methods, such as CreateRoom, DeleteRoom, JoinRoom, and LeaveRoom.
·   	Message sending and receiving methods, such as SendMessage and ReceiveMessage.
·   	Notification methods, such as SendNotification.

The hardest problems to solve in designing a chat server is scalability and
performance. Chat servers need to be able to handle large numbers of users and messages in real-time,
which can be a significant technical challenge.
Other challenges may include ensuring the security of user data and preventing spam or 
abusive behavior within chat rooms.
To address these challenges, it may be necessary to use distributed systems and
technologies such as load balancing, caching, and messaging queues. 
Additionally, proper user input validation and access control must be 
implemented to ensure the security of user data.
