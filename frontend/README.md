# Sports Bike Showroom Frontend App

1. At first we need to do some work before starting project

- Install React Application

```bash
npx create-react-app project-name
```

- Clean the unnessary file from react & make it fresh
  check this commit for the idea https://github.com/Maxyee/sports-bike-showroom/commit/dac28a79dd4ad5a60bea9706d62c5ba19d387555

- Install Tailwindcss to the react project
  Its better to follow the tailwindcss website documentation.

```bash
npm install -D tailwindcss@npm:@tailwindcss/postcss7-compat postcss@^7 autoprefixer@^9
npm install @craco/craco
```

Add Craco scripts our `package.json` file

```json
{
  // ...
  "scripts": {
    "start": "craco start",
    "build": "craco build",
    "test": "craco test",
    "eject": "react-scripts eject"
  }
}
```

Into the root folder create a file called `craco.config.js` and add postcss plugins

```js
// craco.config.js
module.exports = {
  style: {
    postcss: {
      plugins: [require("tailwindcss"), require("autoprefixer")],
    },
  },
};
```

Now we have to create a configuration file called `tailwind.config.js` below command will do that

```bash
npx tailwindcss-cli@latest init
```

now add a line which will remove unused styles in production

```js
purge: ['./src/**/*.{js,jsx,ts,tsx}', './public/index.html'],
```

lets navigate to the `./src/index.css` file add below code

```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

again navigate to the file `./src/index.js` and import that css file

```js
import "./index.css";
```

You must restart the project for watching the output.
Finally its done. now we can do our tailwindcss work

- Lets Make the Home Page Done

In this section we neeed to make 3 component. so make a folder `src/components` and make these files `Header`, `Bike`, `Footer`

```js
// Header.js
import React from "react";

export default function Header() {
  return (
    <div className="flex justify-center text-4xl bg-gray-400">
      Sports Bike Showroom
    </div>
  );
}
```

```js
// Bike.js
import React from "react";

export default function Bike() {
  return (
    <div className="bg-gray-100">
      <div className="flex justify-center space-x-4">
        <div>
          <img src="/images/bmw1000rr.jpg" alt="bike photo" />
        </div>
        <div>
          <p>Model: S1000RR</p>
          <p>Year: 2021</p>
          <p>Price: 19000 GBP</p>
          <p>Engine Speed: 1000cc</p>
        </div>
      </div>
      <div className="bg-black h-1"></div>
    </div>
  );
}
```

```js
//Footer.js
import React from "react";

export default function Footer() {
  return (
    <div className="bg-blue-300 h-12 flex justify-center items-center">
      <h4>All Rights Reserved</h4>
    </div>
  );
}
```

Finally add these 3 components to the `App.js` file

```js
// App.js
import Header from "./components/Header";
import Bike from "./components/Bike";
import Footer from "./components/Footer";

function App() {
  return (
    <div className="font-mono flex flex-col h-screen justify-between">
      <Header />
      <Bike />
      <Bike />
      <Bike />
      <Bike />
      <Footer />
    </div>
  );
}

export default App;
```

Now the frontend is look like this
![alt text](https://github.com/Maxyee/sports-bike-showroom/blob/master/frontend/public/images/bikeScreen.png)

- Install React Router Dom different page navigation

```bash
npm install react-router-dom
```

now we are going to make a page called `AddBike.js`

```js
import React from "react";

export default function AddBike() {
  return (
    <>
      <div>
        <div className="md:grid md:grid-cols-3 md:gap-6">
          <div className="mt-5 md:mt-0 md:col-span-2">
            <form action="#" method="POST">
              <div className="shadow overflow-hidden sm:rounded-md">
                <div className="px-4 py-5 bg-white sm:p-6">
                  <div className="grid grid-cols-6 gap-6">
                    <div className="col-span-6 sm:col-span-3">
                      <label
                        htmlFor="bike-model"
                        className="block text-sm font-medium text-gray-700"
                      >
                        Bike Model
                      </label>
                      <input
                        type="text"
                        name="bike-model"
                        id="bike-model"
                        autoComplete="given-name"
                        className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                      />
                    </div>

                    <div className="col-span-6 sm:col-span-3">
                      <label
                        htmlFor="last-name"
                        className="block text-sm font-medium text-gray-700"
                      >
                        Bike Year
                      </label>
                      <input
                        type="text"
                        name="last-name"
                        id="last-name"
                        autoComplete="family-name"
                        className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                      />
                    </div>

                    <div className="col-span-6 sm:col-span-4">
                      <label
                        htmlFor="email-address"
                        className="block text-sm font-medium text-gray-700"
                      >
                        Bike Price
                      </label>
                      <input
                        type="text"
                        name="email-address"
                        id="email-address"
                        autoComplete="email"
                        className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                      />
                    </div>

                    <div className="col-span-6">
                      <label
                        htmlFor="street-address"
                        className="block text-sm font-medium text-gray-700"
                      >
                        Engine Speed
                      </label>
                      <input
                        type="text"
                        name="street-address"
                        id="street-address"
                        autoComplete="street-address"
                        className="mt-1 focus:ring-indigo-500 focus:border-indigo-500 block w-full shadow-sm sm:text-sm border-gray-300 rounded-md"
                      />
                    </div>

                    <div className="flex text-sm text-gray-600">
                      <label
                        htmlFor="file-upload"
                        className="relative cursor-pointer bg-white rounded-md font-medium text-indigo-600 hover:text-indigo-500 focus-within:outline-none focus-within:ring-2 focus-within:ring-offset-2 focus-within:ring-indigo-500"
                      >
                        <span>Upload a bike photo</span>
                        <input
                          id="file-upload"
                          name="file-upload"
                          type="file"
                          className="sr-only"
                        />
                      </label>
                      <p className="pl-1">or drag and drop</p>
                    </div>
                  </div>
                </div>

                <div className="px-4 py-3 bg-gray-50 text-right sm:px-6">
                  <button
                    type="submit"
                    className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"
                  >
                    Save
                  </button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>

      <div className="hidden sm:block" aria-hidden="true">
        <div className="py-5">
          <div className="border-t border-gray-200" />
        </div>
      </div>
    </>
  );
}
```

after adding this code. now we need to import our browser router into `app.js`

```js
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";

function App() {
  return (
    <div className="font-mono flex flex-col h-screen justify-between">
      <Router>
        <Switch>
          <Route exact path="/addbike">
            <Header />
            <AddBike />
            <Footer />
          </Route>
          <Route exact path="/">
            <Header />
            <Bike />
            <Bike />
            <Bike />
            <Bike />
            <Footer />
          </Route>
        </Switch>
      </Router>
    </div>
  );
}
```

into the `components/Header.js` file we Linked our new `addbike` page

```js
import { Link } from "react-router-dom";

<Link to="/addbike">
  <button className="bg-gray-200">AddBike</button>
</Link>;
```

- Install React-Redux to the project

```bash
npm install react-redux redux redux-thunk js-cookie
```

- Implement the architecure of redux into the project `action`, `reducer`, `store`, `provider`

so this is the one of the interesting part of React with Redux.

lets create a folder called `redux` and then make there more folder there

```bash
mkdir src/redux
mkdir src/redux/store
mkdir src/redux/reducers
mkdir src/redux/actions
```

now create a file called `store.js` into the `src/redux/store`

```js
import { createStore, combineReducers, applyMiddleware, compose } from "redux";
import thunk from "redux-thunk";
import Cookie from "js-cookie";

//const userInfo = Cookie.getJSON('userInfo') || null;

const initialState = {
  //userSignin: { userInfo },
};

const reducer = combineReducers({});

const composeEnhancer = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const store = createStore(
  reducer,
  initialState,
  composeEnhancer(applyMiddleware(thunk))
);
export default store;
```

now we need to import this store to our root `index.js` file

```js
//index.js
import { Provider } from "react-redux";
import store from "./redux/store/store";

ReactDOM.render(
  <Provider store={store}>
    <App />
  </Provider>,
  document.getElementById("root")
);
```

so lets complete redux with a simple `SignIn` actions.

make file called `userActions.js` and install dependencies `axios`

```bash
touch src/redux/actions/userActions.js

npm install axios
```

another folder called `constants` we need and make a folder `userConstants.js`

```bash
mkdir src/constants

touch src/constants/userConstants.js

```

```js
//userConstants.js
export const USER_SIGNIN_REQUEST = "USER_SIGNIN_REQUEST";
export const USER_SIGNIN_SUCCESS = "USER_SIGNIN_SUCCESS";
export const USER_SIGNIN_FAIL = "USER_SIGNIN_FAIL";
```

```js
//userActions.js
import Axios from "axios";
import Cookie from "js-cookie";

import {
  USER_SIGNIN_REQUEST,
  USER_SIGNIN_SUCCESS,
  USER_SIGNIN_FAIL,
} from "../../constants/userConstants";

const signin = (email, password) => async (dispatch) => {
  dispatch({ type: USER_SIGNIN_REQUEST, payload: { email, password } });
  try {
    const { data } = await Axios.post("https://importyourOwnAPI", {
      email,
      password,
    });
    dispatch({ type: USER_SIGNIN_SUCCESS, payload: data });
    Cookie.set("userInfo", JSON.stringify(data));
  } catch (error) {
    dispatch({ type: USER_SIGNIN_FAIL, payload: error.message });
  }
};

export { signin };
```

now we need to work with reducers. make a file called `userReducers.js`

```bash

touch src/redux/reducers/userReducers.js
```

```js
//userReducers.js
import {
  USER_SIGNIN_REQUEST,
  USER_SIGNIN_SUCCESS,
  USER_SIGNIN_FAIL,
} from "../../constants/userConstants";

function userSigninReducer(state = {}, action) {
  switch (action.type) {
    case USER_SIGNIN_REQUEST:
      return { loading: true };
    case USER_SIGNIN_SUCCESS:
      return { loading: false, userInfo: action.payload };
    case USER_SIGNIN_FAIL:
      return { loading: false, error: action.payload };
    case USER_LOGOUT:
      return {};
    default:
      return state;
  }
}

export { userSigninReducer };
```

we completed our actions and reducers. now we have to combine this 2 with store

```js
//store.js
// our new store will look like
import { createStore, combineReducers, applyMiddleware, compose } from "redux";
import thunk from "redux-thunk";
import Cookie from "js-cookie";
import { userSigninReducer } from "../reducers/userReducers";

//const userInfo = JSON.parse(Cookie.get("userInfo")) || null;
const userInfo = Cookie.get("userInfo") || null;
const initialState = {
  userSignin: { userInfo },
};

const reducer = combineReducers({
  userSignin: userSigninReducer,
});

const composeEnhancer = window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

const store = createStore(
  reducer,
  initialState,
  composeEnhancer(applyMiddleware(thunk))
);
export default store;
```

- Make Home page
- Test Home Page
- Make Add Bike Page
- Test Add Bike page
- Make All Bike Page

right now I made a page called `AllBike.js` and put this code:

```js
import React from "react";

const people = [
  {
    name: "Jane Cooper",
    title: "Regional Paradigm Technician",
    department: "Optimization",
    role: "Admin",
    email: "jane.cooper@example.com",
    image:
      "https://images.unsplash.com/photo-1494790108377-be9c29b29330?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=facearea&facepad=4&w=256&h=256&q=60",
  },
  // More people...
];

export default function AllBike() {
  return (
    <div className="flex flex-col">
      <div className="-my-2 overflow-x-auto sm:-mx-6 lg:-mx-8">
        <div className="py-2 align-middle inline-block min-w-full sm:px-6 lg:px-8">
          <div className="shadow overflow-hidden border-b border-gray-200 sm:rounded-lg">
            <table className="min-w-full divide-y divide-gray-200">
              <thead className="bg-gray-50">
                <tr>
                  <th
                    scope="col"
                    className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                  >
                    Model
                  </th>
                  <th
                    scope="col"
                    className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                  >
                    Year
                  </th>
                  <th
                    scope="col"
                    className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                  >
                    Price
                  </th>
                  <th
                    scope="col"
                    className="px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"
                  >
                    Engine Speed
                  </th>
                  <th scope="col" className="relative px-6 py-3">
                    <span className="sr-only">Edit</span>
                  </th>
                  <th scope="col" className="relative px-6 py-3">
                    <span className="sr-only">Delete</span>
                  </th>
                </tr>
              </thead>
              <tbody className="bg-white divide-y divide-gray-200">
                {people.map((person) => (
                  <tr key={person.email}>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center">
                        <div className="flex-shrink-0 h-10 w-10">
                          <img
                            className="h-10 w-10 rounded-full"
                            src={person.image}
                            alt=""
                          />
                        </div>
                        <div className="ml-4">
                          <div className="text-sm font-medium text-gray-900">
                            {person.name}
                          </div>
                          <div className="text-sm text-gray-500">
                            {person.email}
                          </div>
                        </div>
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="text-sm text-gray-900">
                        {person.title}
                      </div>
                      <div className="text-sm text-gray-500">
                        {person.department}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap">
                      <span className="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800">
                        Active
                      </span>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap text-sm text-gray-500">
                      {person.role}
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                      <a
                        href="#"
                        className="text-indigo-600 hover:text-indigo-900"
                      >
                        Edit
                      </a>
                    </td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        </div>
      </div>
    </div>
  );
}
```

- Test All Bike Page
- Make Code Coverage Report
