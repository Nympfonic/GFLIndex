import styles from './dolldetails.module.css';

export default function DollDetails(props) {
    return (
        <div>
            <button onClick={() => props.changeRoute('api/dolls')}>Back to Index</button>

            <div className={styles.dataContent}>
                <img src={"data:image/png;base64," + props.data.image} alt=""/>

                <table className='table table-striped' aria-labelledby='tableLabel'>
                    <thead>
                        <tr className={styles.tableHeadings}>
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
                        <tr className={styles.tableEntries}>
                            <td>{props.data.id}</td>
                            <td>{props.data.name}</td>
                            <td>{props.data.rarity.rarity}</td>
                            <td>{props.data.type.name}</td>
                            <td>
                                {props.data.stats.map(stat =>
                                    <ul key={stat.id}>
                                        <li>HP: <b>{stat.health}</b></li>
                                        <li>Ammo Consumption: <b>{stat.ammoConsumption}</b></li>
                                        <li>Ration Consumption: <b>{stat.rationConsumption}</b></li>
                                        <li><hr></hr></li>
                                        <li>Damage: <b>{stat.damage}</b></li>
                                        <li>Evasion: <b>{stat.evasion}</b></li>
                                        <li>Accuracy: <b>{stat.accuracy}</b></li>
                                        <li>Rate of Fire: <b>{stat.rateOfFire}</b></li>
                                        <li><hr></hr></li>
                                        <li>Movement Speed: <b>{stat.moveSpeed}</b></li>
                                        <li>Armor: <b>{stat.armor}</b></li>
                                        <li>Critical Rate: <b>{stat.criticalRate}</b></li>
                                        <li>Critical Damage: <b>{stat.criticalDamage}</b></li>
                                        <li>Armor Penetration: <b>{stat.armorPenetration}</b></li>
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