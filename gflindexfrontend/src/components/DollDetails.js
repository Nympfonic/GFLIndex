import styles from './dolldetails.module.css';

export default function DollDetails(props) {
    return (
        <div>
            <button onClick={() => props.changeRoute('api/dolls')}>Back to Index</button>

            <div className={styles.dataContent}>
                <img src={"data:image/png;base64," + props.data.image} alt=""/>

                <table className='table table-striped' aria-labelledby='tableLabel'>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Name</th>
                            <th>Rarity</th>
                            <th>Type</th>
                            <th>Stats</th>
                            <th>Tiles</th>
                            <th>Skills</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>{props.data.id}</td>
                            <td>{props.data.name}</td>
                            <td>{props.data.rarity.rarity}</td>
                            <td>{props.data.type.name}</td>
                            <td>
                                {props.data.stats.map(stat =>
                                    <ul key={stat.id}>
                                        <li>{stat.health}</li>
                                        <li>{stat.ammoConsumption}</li>
                                        <li>{stat.rationConsumption}</li>
                                        <li>{stat.damage}</li>
                                        <li>{stat.evasion}</li>
                                        <li>{stat.accuracy}</li>
                                        <li>{stat.rateOfFire}</li>
                                        <li>{stat.moveSpeed}</li>
                                        <li>{stat.armor}</li>
                                        <li>{stat.criticalRate}</li>
                                        <li>{stat.criticalDamage}</li>
                                        <li>{stat.armorPenetration}</li>
                                    </ul>
                                )}
                            </td>
                            <td>
                                {props.data.tiles.map(tile =>
                                    <ul key={tile.id}>
                                        <li>{tile.description}</li>
                                        <li>{tile.image}</li>
                                    </ul>
                                )}
                            </td>
                            <td>
                                {props.data.skills.map(skill =>
                                    <ul key={skill.id}>
                                        <li>{skill.name}</li>
                                        <li>{skill.initialCooldown}</li>
                                        <li>{skill.cooldown}</li>
                                        <li>{skill.description}</li>
                                    </ul>
                                )}
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    );
}