import React, { Component } from 'react';

export class Portfolio extends Component {
    static displayName = Portfolio.name;

  constructor(props) {
    super(props);
    this.state = { positions: [], loading: true };
  }

  componentDidMount() {
    this.getPortfolioInfo();
  }

  static renderPostitionsTable(positions) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>Symbol</th>
            <th>Quantity</th>
            <th>Current Price</th>
            <th>Change Percent</th>
          </tr>
        </thead>
        <tbody>
          {positions.map(position =>
                <tr key={position.Symbol}>
                  <td>{position.Symbol}</td>
                  <td>{position.Quantity}</td>
                  <td>{position.AssetCurrentPrice}</td>
                  <td>{position.AssetChangePercent}</td>
                </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : Portfolio.renderPostitionsTable(this.state.positions);

    return (
      <div>
        <h1 id="tabelLabel" >Portfolio</h1>
        <p>This is a comprehensive list of the stocks you own.</p>
        {contents}
      </div>
    );
  }

    async getPortfolioInfo() {
    const response = await fetch('portfolio');
    const data = await response.json();
    this.setState({ positions: data, loading: false });
  }
}
