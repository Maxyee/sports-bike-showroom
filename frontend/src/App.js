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
