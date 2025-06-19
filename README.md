# Social Network Events App

This project is a full-stack social networking application that allows users to sign up for events, similar to platforms like MeetUp or Facebook Events. The entire application is built completely from scratch, starting with just an empty terminal or command prompt.

## Features
- User authentication (sign up, log in, log out)
- Event creation and management
- RSVP to events
- User profiles
- Explore events by date, location, or category
- Mobile responsive design

## Tech Stack
**Frontend:**
- HTML, CSS, JavaScript (React)
- Tailwind CSS for styling

**Backend:**
- Node.js with Express.js
- RESTful API design

**Database:**
- MongoDB with Mongoose ORM

**Authentication:**
- JWT (JSON Web Tokens)
- Bcrypt for password hashing

**Dev Tools:**
- Git for version control
- ESLint + Prettier for code linting and formatting

## Getting Started
### Prerequisites
- Node.js & npm
- MongoDB installed and running locally or accessible via URI

### Installation
```bash
# Clone the repository
git clone https://github.com/yourusername/social-network-events-app.git
cd social-network-events-app

# Install dependencies for backend
cd server
npm install

# Install dependencies for frontend
cd ../client
npm install
```

### Running the Application
```bash
# Start backend server
cd server
npm start

# Start frontend dev server
cd ../client
npm start
```

## Folder Structure
```
social-network-events-app/
├── client/           # Frontend code (React)
├── server/           # Backend code (Node/Express)
├── README.md         # Project documentation
```

## Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License
[MIT](https://github.com/Alcon-0/social-network-app?tab=MIT-1-ov-file)
