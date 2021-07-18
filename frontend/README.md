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

- Install React Router Dom different page navigation
- Install React-Redux to the project
- Implement the architecure of redux into the project `action`, `reducer`, `store`, `provider`
- Make Home page
- Test Home Page
- Make Add Bike Page
- Test Add Bike page
- Make Code Coverage Report
