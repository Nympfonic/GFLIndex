import React, { Component } from 'react';

import DollDetails from './components/DollDetails';
import DollsIndex from './components/DollsIndex';

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
        this.state = { data: [], loading: true, route: 'api/dolls' };
    }

    componentDidMount() {
        this.populateData(this.state.route);
    }

    changeRoute(route) {
        this.setState({ data: [], loading: true, route: route});
        this.populateData(route);
    }

    renderComponent(data, routePath) {
        var idRegex = /api\/dolls\/\d{1,4}/;
        switch (true) {
            case routePath === 'api/dolls':
                return <DollsIndex data={data} changeRoute={(route) => this.changeRoute(route)} />;
            case idRegex.test(routePath):
                return <DollDetails data={data} changeRoute={(route) => this.changeRoute(route)} />;
            default:
                return null;
        }
    }

    render() {
        let contents = this.state.loading
            ? <p>Loading...</p>
            : this.renderComponent(this.state.data, this.state.route);

        return (
            <main>
                <h1 id="tableLabel" >GFL Index</h1>
                <p>This site contains a list of all dolls (characters) from a Chinese mobile gacha game known as Girls' Frontline.</p>
                {contents}
            </main>
        );
    }

    async populateData(route) {
        const response = await fetch(route);
        const data = await response.json();
        this.setState({ data: data, loading: false });
    }
}
