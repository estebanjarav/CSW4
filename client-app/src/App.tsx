import React, { useEffect, useState } from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {

  const [activities, setActivities] = useState([]);
//creamos un metodo effect que va ir a la url de la API por medio de AXIOS y comunicarse con el servicio de net//
  useEffect(() =>
  {
   axios.get('https://localhost:5001/Activities').then(response => {
     
     console.log(response);
     setActivities(response.data);

   })
  
  }, [])


  return (
    <div>
      <Header as='h2' icon='users' content='Reactivities'/>

      <List>
      {activities.map((activity: any) => (
          <List.Item key = {activity.id}>
          {activity.Title} - {activity.date}
          </List.Item>

        ))}
      </List>
        
      
    </div>
  );
}

export default App;
