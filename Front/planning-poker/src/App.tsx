import React from "react";
import logo from "./logo.svg";
import "./App.css";
import { LoginView } from "./view/LoginView/LoginView";

function App() {
  return (
    <div
      style={{
        position: "absolute",
        height: "100%",
        width: "100%",
        backgroundColor: "#FFFF00",
      }}
    >
      <LoginView></LoginView>
    </div>
  );
}

export default App;
