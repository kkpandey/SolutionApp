import './App.css';
import { useForm } from 'react-hook-form';
import React from 'react';
import { Form, Button } from 'semantic-ui-react';
import axios from "axios";
function App() {
  const { register, handleSubmit, formState: { errors } } = useForm();
  const onSubmit = (data) => {
    console.log(data);
    const datares = {
      employeeId: data.employeeId,
      companyName: data.companyName,
      verificationCode: data.verificationCode,
    };
    axios({
      method: "post",
      url: "https://localhost:44322/api/Employee/Create",
      data: data,
      config: {
        headers: {
          Accept: "application/json",
          "Content-Type": "application/json",
        },
      },
    })
      .then((response) => {
        debugger;
        console.log(response);
        alert(response.data.message);
      })
      .catch((error) => {
        console.log("the error has occured: " + error);
      });

}
  return (
    <div className="App">
      <Form onSubmit={handleSubmit(onSubmit)}>
      <Form.Field>
        <div className='row'>
          <div className='col-md:3'>
          <input type="number" name="employeeId" placeholder="Eployee Number"   
          {...register("employeeId", { required: true, maxLength: 10 })}
          />
          </div>
        </div>
        </Form.Field>
                {errors.employeeId && <p className="text-error">Please check the Employee Number</p>}
                <Form.Field>
        <div className='row'>
          <div className='col-md:3'>
          <input type="text" name="companyName" placeholder="Company Name"  
          {...register("companyName", { required: true, maxLength: 10 })}
          />
          </div>
        </div>
        </Form.Field>
        {errors.companyName && <p className="text-error">Please check the company name</p>}
        <Form.Field>
        <div className='row'>
          <div className='col-md:3'>
          <input type="text" name="verificationcode" placeholder="Verification Code"  
          {...register("verificationcode", { required: true, maxLength: 10 })}
          />
          </div>
        </div>
        </Form.Field>
        {errors.verificationcode && <p className="text-error">Please check the verificationcode name</p>}
        <Button type='submit'>Submit</Button>
        </Form>
    </div>
  );
}

export default App;
