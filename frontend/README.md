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
- Implement the architecure of redux into the project `action`, `reducer`, `store`, `provider`
- Make Home page
- Test Home Page
- Make Add Bike Page
- Test Add Bike page
- Make Code Coverage Report
