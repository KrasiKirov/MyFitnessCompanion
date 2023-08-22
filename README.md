# MyFitnessCompanion

A comprehensive fitness tracking application built using ASP.NET MVC. Whether you're a fitness enthusiast or a beginner, MyFitnessCompanion is designed to help you keep track of your workouts, nutrition, and progress!

## 🏠 Home Page
The home page serves as the initial landing page for "MyFitnessCompanion". It welcomes users with an elegant design that instantly gives an overview of what the application offers.

### Features and Functionalities:

#### Dynamic Greeting:

* The home page identifies if the user is authenticated. If the user is logged in, the "Get Started" button will redirect them to their personal dashboard. If not, it will direct them to the login page.

#### Concise Introduction:

* The page introduces the application with the title and tagline. The brief description provides users with an idea of what they can achieve using the app.

#### Key Features Highlight:

* The three main features of the application - Exercise Tracking, Nutrition Tracking, and Progress Tracking - are visually represented using icons and succinctly described, giving users a snapshot of the core functionalities.

### Styling:
The home page adopts a clean and modern aesthetic with a harmonized color palette. The design is responsive, making use of flexbox to ensure the content looks well-arranged on various screen sizes.

* The main color (**#4CAF50**) is vibrant, promoting the idea of health and growth.
* Icons from the Font Awesome library have been integrated to visually represent each main feature, enhancing the user experience.
* Hover effects on buttons and feature cards add interactivity, providing a smooth and engaging experience for users.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/52653070-910c-480e-b994-aba30bd04bdd)
## 🔑 Login Page
The login page is a critical component of "MyFitnessCompanion", providing the authentication gateway for registered users to access their personal data and tools.

### Features and Functionalities:

#### User Authentication:

* The page prompts users for their registered Email and Password.
* "Remember me?" option allows users to stay logged in, reducing the need for repeated authentication on subsequent visits.

#### Validation & Error Handling:

* The page comes equipped with server-side validation for the email and password fields.
* Users receive error messages for invalid input or failed login attempts, helping them troubleshoot and ensuring security.
* The system redirects authenticated users if they land on the login page.
* Account lockout mechanisms are in place for additional security, though not triggering on failed login attempts in this implementation.
* There's a provision for Two-Factor Authentication (not visible in the provided markup but indicated in the logic), enhancing the security layer.

#### External Logins:

* While the provided code mentions external logins (e.g., Google, Facebook), it's not explicitly displayed in the markup. However, the backend logic is set up to support such integrations, offering versatility in login methods.

### Backend Logic:
The backend for the login feature utilizes ASP.NET Core Identity, offering a robust and secure authentication mechanism.

* The **SignInManager** is leveraged to handle user sign-ins.
* The system logs different events (successful login, account lockout) using the integrated **ILogger**, helping in debugging, monitoring, and potential security audits.
* Redirect mechanisms are in place to guide the user flow post-login, either to the dashboard or other relevant pages based on different login scenarios.

### Login
![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/aef80354-15aa-4fd3-9842-ac53e541043a)
### Registration
![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/e4aa0dc3-dafb-4ca9-a072-c89390a652ff)
## 📖 About Page

The About page is an integral part of MyFitnessCompanion, offering users a comprehensive overview of the platform, its mission, and the key features it boasts.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/9629ab3d-a990-4db4-9d95-f40b716c0787)
## 📊 Dashboard

The dashboard is the heartbeat of MyFitnessCompanion, delivering users a centralized view of their fitness journey. It's aesthetically pleasing, intuitive, and interactive, designed to inspire users and facilitate quick access to major features.

### Features and Functionalities:

#### Responsive Design:

* Adapts to various screen sizes to ensure optimal viewing experience across devices.
* Nested within a container for consistent alignment and spacing.

#### Interactive Feature Cards:

* **Exercise Tracker**:
  * Function: Directs users to the exercise tracking module, enabling them to log and analyze their workouts.
* **Goal Setting**:
   * Function: Empowers users to define and refine their fitness targets, keeping motivation high.
* **Nutrition Tracker**:
   * Function: Aids users in logging their meals and gauging nutritional intake, promoting a balanced diet.
* **Progress Tracker**:
  * Function: Provides a visual narrative of the user's evolution over time, driving insights and affirming commitment.

#### Aesthetic & Interactivity:

* The cards boast a minimalist design with eye-catching icons at the forefront.
* Hover animations intensify user engagement, subtly elevating the card on mouseover.
* The color palette is fitness-themed, with the dominant green symbolizing health and vitality.

### Styling Insights:

* **Body**: A neutral background offers visual comfort and highlights the main content.
* **Container**: Centrally aligned with a shadow effect, encapsulating all dashboard cards.
* **Cards**:
  * Clean white background ensures the content pops.
  * A slight shadow offers depth.
  * Flexbox is employed for center alignment and layout structuring.
  * Smooth transitions create a more dynamic interaction.
  * Title and description are precisely positioned for clarity and aesthetic appeal.
  * Icons are emphasized in size and hue, resonating with the fitness theme and guiding user attention.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/4f99eea6-3a07-4f88-b061-1b3a223a9aae)
## 📋 Exercise Tracker

The Exercise Tracker is an essential feature of the platform. It's user-friendly, interactive, and data-centric, ensuring users have a seamless experience logging and managing their workouts.

### Features and Functionalities:

#### Responsive and Modern UI:

* Adapts to multiple screen sizes.
* Utilizes the Roboto font for a modern, clean look.

#### Exercise Input Form:

* Allows users to easily input exercise details:
  * Exercise Name
  * Exercise Duration
  * Exercise Date

#### Exercise Table:

* Displays all the exercises input by the user.
* Users can also delete specific exercises with a dedicated delete button.

#### Persistent Data:

* Exercises are stored in the **localStorage**, ensuring user data is not lost even if the page is refreshed.
* The data is loaded into the table when the page loads.

#### Feedback to the User:

* If a user tries to add an exercise without filling out all the fields, a message will display informing them of the missing fields.

### Styling Insights:

#### Base Styles:

* The body incorporates a soothing background and dark text for contrast.
* Centralized headings emphasize the main content.

#### Form Styles:

* A container encapsulates the form elements, ensuring they're well-aligned and spaced.
* Labels and input fields are clearly distinguished and adequately spaced for usability.
* The 'Add Exercise' button uses a contrasting color to grab attention.

#### Table Styles:

* The table layout ensures all exercise details are easily readable.
* Zebra striping is used for better readability of consecutive rows.
* Each column has a dedicated width, ensuring consistent alignment.
* Hover effects enhance user interactivity.
* The delete button is highlighted in red for clarity and importance.

### Javascript Insights:

#### Data Management:

* The **exercises** array manages the logged exercises.
* The **addExercise** function handles data validation, data addition, and storage updates.
* Exercises are appended to the table dynamically.
* The **deleteExercise** function allows users to remove specific exercises, both from the display and storage.

#### Data Persistence:

* The use of localStorage ensures data persistence across sessions.
* On page load, previously stored exercises are fetched and displayed.

In summary, the Exercise Tracker offers a holistic, intuitive, and efficient means for users to log, view, and manage their workouts. The robust data management, combined with an elegant and interactive UI, enhances the overall user experience. Future enhancements could include categorizing exercises, integrating exercise metrics, or syncing with other fitness apps.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/1c1b899d-cb51-407f-ae87-cbf421b4a463)
## 📋 Goal Setting

The Goal Setting page is a vital component of the MyFitnessCompanion platform. Designed to inspire and facilitate users in defining their fitness journey, it seamlessly integrates goal management in one interactive platform.

### Features and Functionalities:

#### Responsive and Modern UI:

* Compatible with a range of device screen sizes.
* Implements the Roboto font, adding a modern touch.

#### Goal Input Form:

* Simplifies the process for users to outline their fitness goals:
  * Goal Description
  * Date of Entry
* Inbuilt validation mechanisms ensure every field is populated before goal submission.

#### Dynamic Goals Display:

* Showcases all the fitness goals noted down by the user.
* Possibility to go to Progress Tracker page to monitor progress of the goal via a dedicated button.
* Provides users the flexibility to delete specific goals via a dedicated removal button.

#### Persistent Data:

* Goals are consistently stored in the localStorage, guaranteeing no data loss upon refreshing the page.
* Data gets retrieved and showcased instantly upon page initialization.

#### Feedback Mechanism:

* In scenarios where users attempt to add a goal without completing all necessary fields, an alert notifies them of the required inputs.

### Styling Insights:

#### Base Styles:

* A calming background complements the dark text, ensuring readability.
* Main content is accentuated through centralized headings.

#### Form Styles:

* A container holds all form components, guaranteeing alignment and spacing.
* Clear demarcation between labels and input boxes, amplified by apt spacing.
* The 'Add Goal' button employs a standout color for immediate recognition.

#### Goals Display Styles:

* Each goal entry ensures that the content and date are easily discernible.
* Hover animations amplify user engagement.
* The 'Remove' button is accentuated in red, signaling its critical functionality.

### Javascript Insights:

#### Data Management:

* A dedicated **goals** array keeps track of all set goals.
* The **addGoal** function manages data validation, goal addition, and subsequent updates to storage.
* Goals are dynamically incorporated into the display.
* The **removeGoal** function facilitates users in erasing specific goals from both the UI and storage.

#### Data Persistence:

* Harnessing localStorage, data remains consistent across multiple sessions.
* During page initialization, all previously established goals are extracted and showcased.

The Goal Setting page provides a comprehensive, user-centric, and efficient platform for users to articulate, oversee, and administer their fitness aspirations. A fusion of robust data management with a sleek, user-friendly UI culminates in a stellar user experience. Future iterations might encompass goal categorization, integration with progress trackers, or syncing capabilities with other modules of the app.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/cf27b3d7-65ce-42c1-b55e-ae6014a51849)
## 📋 Progress Tracker

The Progress Tracker is a stellar addition to the platform. With an emphasis on monitoring user progression towards their set objectives, it presents a user-friendly method to visually and efficiently track one's fitness journey.

### Features and Functionalities:

#### Responsive and Clean UI:

* Accommodates multiple device screens.
* Uses 'Arial' font, a universal typeface that promises readability and clarity.
* Centralized header element emphasizes the core purpose of the page.

#### Dynamic Progress Sections:

* Users' goals are fetched and visual progress sections are generated.
* Each section is independent, facilitating individual tracking of multiple objectives.
* Easily identifiable input fields are available for the initial, objective, and progress values.

#### Interactive and Intuitive Elements:

* An _Add Progress Input_ button allows users to incrementally track their progress, with a limit set to prevent data overload.
* A green-themed, visually pleasing progress bar graphically showcases advancement towards the goal.
* The _Save Progress_ button updates progress data in real-time and adjusts the progress bar accordingly.

#### Persistent Data Management:

* Users' progress data is stored in localStorage for session consistency.
* Existing data is fetched and loaded into their respective sections on page load.

### Styling Insights:

#### Base Styles:

* A light theme, paired with a comforting background, ensures a serene user experience.
* The main container has been optimized for width, ensuring adequate spacing and presentation.

#### Interactive Elements' Styles:

* Inputs and buttons are styled with rounded edges and soft shadows, promising an appealing look.
* Hover transitions on buttons provide tactile feedback, enhancing user interactivity.
* The progress bar sports a dynamic fill to visually represent the user's progress.

### Javascript Insights:

* The **loadProgressSections()** function efficiently fetches and displays all progress sections.
* A modular approach with the **addProgressSection()** function keeps the code maintainable, allowing for easy scalability and additions.
* Real-time updates and validations ensure the integrity of user data and its representation.

In essence, the Progress Tracker stands as an instrumental tool for users who wish to visualize their progress on the path to achieving their fitness objectives. By amalgamating an aesthetic design, user-focused features, and efficient data handling, it ensures an enriched user experience. As a prospective enhancement, this feature could benefit from analytics insights, graphical representations, or integration with dietary trackers.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/90c8c19b-6686-4391-a78e-a528f69460fb)
![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/238a0cfb-a6ad-480e-b071-770c5e5e8e98)
## 🍽️ Nutrition Tracker

The Nutrition Tracker is a pivotal component of MyFitnessCompanion, providing users with a comprehensive tool to monitor their nutritional intake and make informed dietary decisions. This feature combines a user-friendly interface with data-driven insights, empowering users to achieve their health goals.

### Features and Functionalities:

#### Responsive and Intuitive UI:
* The interface dynamically adapts to various screen sizes, ensuring seamless usability.
* Employing the "Segoe UI" font family contributes to a modern, clean look.

#### Food Description Input:
* Users can effortlessly input details about their meals, including descriptions of the food items consumed.
* The "Analyze" button initiates data retrieval for nutritional analysis.

#### Nutrition Data Display:
* The feature visualizes nutritional information in a structured table format, including:
  * Food Name
  * Calories
  * Protein Content (g)
  * Fat Content (g)
  * Carbohydrate Content (g)
* The table incorporates zebra striping for improved readability, and hover effects enhance user interaction.

#### Cumulative Nutrition Tracking:
* Daily cumulative nutritional values are calculated and presented for quick reference.
* Total Calories, Proteins, Fats, and Carbohydrates are displayed in a user-friendly format.

#### Data Persistence and Storage:
* The application employs **localStorage** to maintain a record of user-inputted food items and cumulative nutrition data.
* Data is loaded into the table upon page load, ensuring continuity across sessions.

### Styling Insights:

#### Base Aesthetic:
* The background gradient (linear) and color palette foster a visually pleasing backdrop for the content.
* Dark text against the light background prioritizes content legibility.

#### Input Form Styling:
* The container arrangement streamlines the alignment and spacing of form elements.
* Differentiation between labels and input fields is evident, enhancing user comprehension.
* The "Analyze" button stands out with its vibrant color.

#### Table Design:
* The table's architecture promotes clear data representation.
* Zebra striping enhances visual clarity, making it easier to distinguish between different rows.
* Column widths are well-defined, maintaining a consistent and organized appearance.
* The delete button is highlighted in red for visual emphasis and clear action.

### Javascript Insights:

#### Data Management:
* Nutritional information for each food item is stored as objects in the foodEntries array.
* The **addToTable** function dynamically adds food items to the table.
* Cumulative nutritional data, encompassing calories, proteins, fats, and carbs, is meticulously updated and presented in real-time.

#### Data Persistence:
* The utilization of **localStorage** ensures that nutrition data remains accessible even after browser refreshes.
* Upon page reload, previously saved food items are loaded into the table.

The Nutrition Tracker isn't just an application feature—it's a powerful tool for informed dietary decisions. Combining a well-thought-out design, efficient data management, and responsive visuals, this feature provides users with a valuable resource to enhance their nutritional awareness. As the platform evolves, potential enhancements might include the integration of meal categorization, micronutrient tracking, or synchronization with external nutrition databases.

![image](https://github.com/KrasiKirov/MyFitnessCompanion/assets/113156316/a4f8a538-1a53-49fe-833d-2ab231f0d74b)
