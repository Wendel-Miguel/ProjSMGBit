import React, { Component } from 'react';
import './ComponentsStyle/HomeStyle.css'

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');

export class Home extends Component {
  static displayName = Home.name;

  constructor ()
  {
    super()

    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    this.csvPath = event.target.value;
    var txt_csvPath = document.getElementById("txt_csvPath");
    txt_csvPath.value = this.csvPath;
    this.SendCsvTravel();
  }

  handleSubmit(){
    this.SendCsvTravel()
  }

  render() {
    return (
      <form onSubmit={this.handleSubmit}>
        <div>
          <input type="text" id="txt_csvPath" name="txt_csvPath" placeholder="Insira um arquivo .xlsx" readOnly/>
          <label for="input_csvPath">Selecionar Arquivo</label>
          <input type="file" id="input_csvPath" name="input_csvPath" onChange={this.handleChange} accept=".xlsx, xls"/>
        </div>
        <input type="submit" value="Processar Viagem" />
      </form>
    );
  }

  async SendCsvTravel() {
    try {
      const response = await fetch('travel/startprocesstravel', {
        method:'POST',
        body: this.csvPath,
        headers : {
          'Content-type': 'plain/text'
        }
      });
      const data = await response.json();
      console.log(data);
    }
    catch (e)
    {
      console.log("Error" + e);
    }
  }
}
