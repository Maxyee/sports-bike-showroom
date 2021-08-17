import Header from "./components/Header";
import Bike from "./components/Bike";
import Footer from "./components/Footer";
import { BrowserRouter as Router, Switch, Route} from "react-router-dom";
import AddBike from "./pages/AddBike";

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

export default App;
