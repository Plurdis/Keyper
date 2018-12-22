using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyper.Users
{
    public enum UserLevel
    {
        /// <summary>
        /// 슈퍼 어드민입니다. 모든 권한을 가질 수 있습니다.
        /// </summary>
        SuperAdministrator = 0,
        /// <summary>
        /// 어드민입니다. 위험 요소를 제외한 모든 권한을 가집니다.
        /// </summary>
        Administrator = 1,
        /// <summary>
        /// 일반 유저입니다. 기본적인 권한만 가질 수 있습니다.
        /// </summary>
        User = 2,
        
        /// <summary>
        /// 알 수 없는 유저입니다. 오류일 가능성이 제일 높습니다.
        /// </summary>
        Unknown = -1

    }
}
